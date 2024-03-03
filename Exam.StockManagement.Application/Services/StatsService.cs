using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Domain.Entities.Models;
using System.Linq.Expressions;

namespace Exam.StockManagement.Application.Services
{
    public class StatsService : IStatsService
    {
        public Task<Stats> Create(Stats entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<Stats, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Stats>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Stats> GetByAny(Expression<Func<Stats, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Stats> Update(Stats entity)
        {
            throw new NotImplementedException();
        }
    }
}
