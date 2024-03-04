// Ignore Spelling: conf

using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs.Auth;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Domain.Exceptions;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace Exam.StockManagement.Application.Services.AuthServices
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration? _conf;
        private readonly IUserService _userService;

        public AuthService(IConfiguration conf, IUserService userService)
        {
            _conf = conf;
            _userService = userService;
        }

        public async Task<ResponseLogin> GenerateToken(CheckEmail model, string path)
        {
            var login = new RequestLogin()
            {
                Email = model.Email,
            };

            if (File.ReadAllText(path) != model.Code && await UserExist(login))
            {
                return new ResponseLogin { Token = "503" };
            }

            var result = await _userService.GetByEmail(model.Email);

            IEnumerable<int> permissionsId = new List<int>();
            if (result.Role == "Admin")
                permissionsId = new List<int>() { 101, 102, 103, 104, 105, 106, 107, 108, 201, 202, 203, 204, 205, 206, 207, 208 };
            else if (result.Role == "Client")
                permissionsId = new List<int>() { 201, 202, 203, 204, 205, 206, 207, 208 };

            string permmisionJson = JsonSerializer.Serialize(permissionsId);

            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Role, result.Role!),
                new Claim("Login", model.Email),
                new Claim("UserID", result.Id.ToString()),
                new Claim("CreatedDate", DateTime.UtcNow.ToString()),
                new Claim("permissions",permmisionJson)
            };

            File.Delete(path);

            return await GenerateToken(claims);
        }

        public async Task<ResponseLogin> GenerateToken(IEnumerable<Claim> additionalClaims)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_conf["JWT:Secret"]!));

            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var exDate = Convert.ToInt32(_conf["JWT:ExpireDate"] ?? "10");

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, EpochTime.GetIntDate(DateTime.UtcNow).ToString(CultureInfo.InvariantCulture), ClaimValueTypes.Integer64)
            };

            if (additionalClaims?.Any() == true)
                claims.AddRange(additionalClaims);


            var token = new JwtSecurityToken(
                issuer: _conf["JWT:ValidIssuer"],
                audience: _conf["JWT:ValidAudience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(exDate),
                signingCredentials: credentials);

            return new ResponseLogin()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };


        }

        public async Task<bool> UserExist(RequestLogin user)
        {
            if (user.Email == null || user.Password == null)
            {
                throw new NotFoundException();
            }

            var result = await _userService.GetByEmail(user.Email);
            var hash = new HashingPassword();

            if(result != null && hash.VerifyPassword(
                user.Password, result.Password, result.Salt))
            {
                return true;
            }
            return false;
        }

        public async Task<User> RegisterUser(RequestSignUp signUp)
        {
            var result = await _userService.Create(signUp);
            return result;
        }
    }
}
