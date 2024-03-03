using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.Infrastructure.BaseRepositories
{
    public class StatsRepository : BaseRepository<Stats>, IStatsService
    {
        public StatsRepository(StockManagementDbContext context) : base(context)
        {
        }
    }
}
