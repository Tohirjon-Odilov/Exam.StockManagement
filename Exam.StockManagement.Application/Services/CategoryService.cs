using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> Create(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            var result = await _categoryRepository.Create(new Category { CategoryName = name });

            return result;
        }

        public async Task<Category> Delete(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("id");
            }

            var result = await _categoryRepository.Delete(x => x.CategoryId == id);

            if (result)
            {
                return new Category { CategoryName = "Deleted" };
            } else
            {
                return new Category { CategoryName = "Not Delete" };
            }


        }

        public async Task<List<Category>> GetAll()
        {
            var result = await _categoryRepository.GetAll();

            return result.ToList();
        }

        public async Task<Category> Update(int id, string name)
        {
            var entity = new Category { CategoryId = id, CategoryName = name };

            var result = await _categoryRepository.Update(entity);

            return result;
        }
    }
}
