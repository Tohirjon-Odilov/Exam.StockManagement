using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository statsRepository;

        public StatsService(IStatsRepository statsRepository)
        {
            this.statsRepository = statsRepository;
        }

        public Task<string> GetAllPrice()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAllQuantity()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetByCategoryPrice(int category_id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetByCategoryQuantity(int category_id)
        {
            throw new NotImplementedException();
        }
    }
}
