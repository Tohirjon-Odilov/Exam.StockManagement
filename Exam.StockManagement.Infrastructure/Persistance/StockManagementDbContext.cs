using Exam.StockManagement.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.StockManagement.Infrastructure.Persistance
{

    public class StockManagementDbContext : DbContext
    {
        public StockManagementDbContext(DbContextOptions<StockManagementDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
