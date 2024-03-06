using Exam.StockManagement.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Exam.StockManagement.Infrastructure.Persistance
{

    public class StockManagementDbContext : DbContext
    {
        public StockManagementDbContext(DbContextOptions<StockManagementDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

    }
}
