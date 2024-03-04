namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IStatsService
    {
        public Task<int> GetQuantity();
        public Task<int> GetByCategoryQuantity(int category_id);
        public Task<int> GetSum();
        public Task<int> GetByCategorySum(int category_id);
    }
}
