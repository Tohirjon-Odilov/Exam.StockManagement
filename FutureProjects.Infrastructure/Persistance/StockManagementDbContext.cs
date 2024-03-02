using Microsoft.EntityFrameworkCore;

namespace Exam.StockManagement.Infrastructure.Persistance
{

    public class StockManagementDbContext : DbContext
    {
        public StockManagementDbContext(DbContextOptions<StockManagementDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Exam.StockManagement.Domain.Entities.Models.User> Users { get; set; }
    }


    //public class MyDbContextFactory : IDesignTimeDbContextFactory<FutureProjectsDbContext>
    //{
    //    private readonly IConfiguration _conf;

    //    public MyDbContextFactory(IConfiguration conf)
    //    {
    //        _conf = conf;
    //    }

    //    public FutureProjectsDbContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<FutureProjectsDbContext>();
    //        optionsBuilder.UseNpgsql(_conf.GetConnectionString("FutureProjectsConnectionString"));
    //        throw new System.NotImplementedException();
    //    }
    //}
}
