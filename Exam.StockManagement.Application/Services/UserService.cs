using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.DTOs.Auth;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Domain.Entities.ViewModels;
using System.Linq.Expressions;

namespace Exam.StockManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> Create(RequestSignUp requestSignUp)
        {
            var hasEmail = await _userRepository.GetByAny(x => x.Email == requestSignUp.Email);

            if (requestSignUp.Password != requestSignUp.ConfirmPassword)
            {
                return new User { Email = "501" };
            }

            if (hasEmail != null)
            {
                return new User { Email = "502" };
            }

            var hash = new HashingPassword();

            User? user = new User()
            {
                Name = requestSignUp.Name,
                Email = requestSignUp.Email,
                Password = hash.HashPassword(requestSignUp.Password, out byte[]? salt),
                Salt = Convert.ToHexString(salt),
                Role = requestSignUp.Role
            };

            var result = await _userRepository.Create(user);

            return result;
        }

        public async Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            var result = await _userRepository.Delete(expression);

            return result;
        }

        public async Task<IEnumerable<UserViewModel>> GetAll()
        {
            var users = await _userRepository.GetAll();

            var result = users.Select(model => new UserViewModel
            {
                Name = model.Name,
                Email = model.Email,
                Role = model.Role,
            });

            return result;
        }

        public async Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            var result = await _userRepository.GetByAny(expression);

            return result;
        }

        public async Task<User> GetByEmail(string email)
        {
            var result = await _userRepository.GetByAny(x => x.Email == email);
            return result;
        }

        public async Task<User> GetById(int Id)
        {
            var result = await _userRepository.GetByAny(x => x.Id == Id);
            return result;
        }

        public async Task<User> Update(int Id, UserDTO userDTO)
        {
            var res = await _userRepository.GetByAny(x => x.Id == Id);

            if (res != null)
            {
                var user = new User()
                {
                    Name = userDTO.Name,
                    Email = userDTO.Email,
                    Password = userDTO.Password,
                    Role = userDTO.Role,
                };
                var result = await _userRepository.Update(user);

                return result;
            }
            return new User();
        }
    }
}
