using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IStatsService
    {
        public Task<Product> GetAllQuantity();
        public Task<List<Product>> GetByCategoryQuantity(int category_id);
        public Task<string> GetAllPrice();
        public Task<string> GetByCategoryPrice(int category_id);
    }
}
