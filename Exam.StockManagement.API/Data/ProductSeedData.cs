using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.API.Data
{
    public static class ProductSeedData
    {
        public static async Task InitiliazeDataAsync(this IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetRequiredService<StockManagementDbContext>();
            if (!db.Products.Any())
            {
                List<Product> transports = [
                     new Product
                     {
                        ProductName = "Asus TUF Gaming A17",
                        ProductDescription = "AMD Ryzen™ 7 6800H",
                        ProductPrice = 1200,
                        ProductPicture = @"\images\51ZOFgc-4yL._AC_UF894,1000_QL80_.jpg",
                        CreatedAt = DateTime.UtcNow,
                     },
                     new Product
                     {
                        ProductName = "Lenovo Legion 5 Pro",
                        ProductDescription = "16ith6 i7-11800H 16/512GB SSD RTX3050-4GB 16",
                        ProductPrice = 20,
                        ProductPicture = @"\images\",
                        CreatedAt = DateTime.UtcNow,
                     }
                     ];
                db.Products.AddRange(transports);
                await db.SaveChangesAsync();
            }
        }
    }
}
