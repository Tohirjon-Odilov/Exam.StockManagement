using Exam.StockManagement.Application.Abstractions;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.Infrastructure.BaseRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(StockManagementDbContext context) : base(context)
        {
        }
    }
}
