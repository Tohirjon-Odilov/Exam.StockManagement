using Exam.StockManagement.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.StockManagement.Infrastructure.Persistance.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName)
                .HasMaxLength(100);

            builder.Property(x => x.ProductDescription)
                .HasMaxLength(100);
        }
    }
}
