using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using System.Linq.Expressions;

namespace Exam.StockManagement.Application.Services
{
    public class ProductService : IProductRepository
    {
        public Task<Product> Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByAny(Expression<Func<Product, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Product> Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
