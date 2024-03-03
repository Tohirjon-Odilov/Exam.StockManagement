using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.Infrastructure.BaseRepositories
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(StockManagementDbContext context) : base(context)
        {
        }
    }
}
