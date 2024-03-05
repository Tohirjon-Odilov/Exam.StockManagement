using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Infrastructure.Persistance;

namespace Exam.StockManagement.API.Data
{
    public static class CategorySeedData
    {
        public static async Task InitiliazeDataAsync(this IServiceProvider serviceProvider)
        {
            var db = serviceProvider.GetRequiredService<StockManagementDbContext>();
            if (!db.Categories.Any())
            {
                List<Category> Categories = [
                     new Category
                     {
                         CategoryName = "Kompyuter"
                     },
                     new Category
                     {
                        CategoryName = "Telefon"
                     },
                     new Category
                     {
                         CategoryName = "Monitor"
                     },
                     new Category
                     {
                         CategoryName = "Quloqchin"
                     }
                     ];
                db.Categories.AddRange(Categories);
                await db.SaveChangesAsync();
            }
        }
    }
}
