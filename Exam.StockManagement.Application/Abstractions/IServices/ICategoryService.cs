using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface ICategoryService
    {
        public Task<Category> Create(string name);
        public Task<List<Category>> GetAll();
        public Task<Category> Update(int id, string name);
        public Task<Category> Delete(int id);
    }
}
