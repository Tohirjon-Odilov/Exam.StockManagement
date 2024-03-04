using Exam.StockManagement.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exam.StockManagement.Infrastructure.Persistance.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(30);

            builder.Property(x => x.Email)
                .HasMaxLength(50);

            builder.Property(x => x.Role)
                .HasMaxLength(20);
        }
    }
}
