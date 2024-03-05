namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IStatsService
    {
        public Task<int> GetQuantity();
        public Task<int> GetByCategoryQuantity(string categoryName);
        public Task<int> GetSum();
        public Task<int> GetByCategorySum(string categoryName);
    }
}
