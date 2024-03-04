using Exam.StockManagement.Domain.Entities.DTOs.Auth;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IAuthService
    {
        public Task<ResponseLogin> GenerateToken(CheckEmail model, string path);
        public Task<bool> UserExist(RequestLogin user);
        public Task<User> RegisterUser(RequestSignUp signUp);
    }
}
