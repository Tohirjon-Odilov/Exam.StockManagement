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
                .HasMaxLength(150);
            builder.Property(x => x.ProductPicture)
                .HasMaxLength(250);
        }
    }
}
