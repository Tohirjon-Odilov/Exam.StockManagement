using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IProductService
    {
        public Task<Product> Create(ProductDTO product);
        public Task<List<Product>> GetAll();
        public Task<List<Product>> GetByCategory(string categoryName);
        public Task<string> Update(ProductDTO product);
        public Task<string> Delete(int Id);
    }
}
