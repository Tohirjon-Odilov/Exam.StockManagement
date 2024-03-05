using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;

namespace Exam.StockManagement.Application.Services
{
    public class StatsService : IStatsService
    {
        private readonly IStatsRepository statsRepository;

        public StatsService(IStatsRepository statsRepository)
        {
            this.statsRepository = statsRepository;
        }

        public async Task<int> GetSum()
        {
            var result = await statsRepository.GetAll();

            return result.Sum(x => x.ProductPrice);
        }

        public async Task<int> GetQuantity()
        {
            var result = await statsRepository.GetAll();
            return result.Count();
        }

        public async Task<int> GetByCategorySum(string categoryName)
        {
            var datas = await statsRepository.GetAll();
            var result = datas.Where(x => x.Category.CategoryName == categoryName);
            return result.Sum(x => x.ProductPrice);
        }

        public async Task<int> GetByCategoryQuantity(string categoryName)
        {
            var datas = await statsRepository.GetAll();
            var result = datas.Where(x => x.Category.CategoryName == categoryName);
            return result.Count();
        }
    }
}
