using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using System.Linq.Expressions;

namespace Exam.StockManagement.Application.Services
{
    public class CategoryService : ICategoryRepository

    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Task<Category> Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetByAny(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Category> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
