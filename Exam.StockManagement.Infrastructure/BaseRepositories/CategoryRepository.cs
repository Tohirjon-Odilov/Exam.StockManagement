using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.Infrastructure.BaseRepositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(StockManagementDbContext context) : base(context)
        {
        }
    }
}
