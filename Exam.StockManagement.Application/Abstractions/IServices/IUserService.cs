using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.DTOs.Auth;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Domain.Entities.ViewModels;
using System.Linq.Expressions;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IUserService
    {
        public Task<User> Create(RequestSignUp requestSignUp);
        public Task<User> GetByEmail(string email);
        public Task<IEnumerable<UserViewModel>> GetAll();
        public Task<bool> Delete(Expression<Func<User, bool>> expression);
        public Task<User> Update(int Id, UserDTO userDTO);
    }
}
