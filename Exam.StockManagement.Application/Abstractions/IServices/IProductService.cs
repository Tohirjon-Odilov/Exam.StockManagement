using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.ViewModels;

namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IProductService
    {
        public Task<ProductViewModel> Create(ProductDTO product, string path);
        public Task<List<ProductViewModel>> GetAll();
        public Task<List<ProductViewModel>> GetByCategory(string categoryName);
        public Task<string> Update(ProductDTO product);
        public Task<string> Delete(int Id);
    }
}
