using Exam.StockManagement.Domain.Entities.DTOs;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IAuthService
    {
        public Task<ResponseLogin> GenerateToken(RequestLogin user);
    }
}
