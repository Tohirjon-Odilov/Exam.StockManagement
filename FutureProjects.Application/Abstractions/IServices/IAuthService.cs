using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IAuthService
    {
        public Task<ResponseLogin> GenerateToken(RequestLogin user);
    }
}
