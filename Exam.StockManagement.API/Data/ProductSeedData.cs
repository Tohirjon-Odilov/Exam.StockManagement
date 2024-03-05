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
                         CategoryId = 1,
                        ProductName = "Asus TUF Gaming A17",
                        ProductDescription = "AMD Ryzen™ 7 6800H",
                        ProductPrice = 1200,
                        ProductPicture = @"\images\51ZOFgc-4yL._AC_UF894,1000_QL80_.jpg",
                        CreatedAt = DateTime.UtcNow,
                     },
                     new Product
                     {
                         CategoryId = 1,
                        ProductName = "Lenovo Legion 5 Pro",
                        ProductDescription = "16ith6 i7-11800H 16/512GB SSD RTX3050-4GB 16",
                        ProductPrice = 10000000,
                        ProductPicture = @"\images\462hon597tbbhjcmj0o1ycjaciyqxyd6.jpg",
                        CreatedAt = DateTime.UtcNow,
                     },
                     new Product
                     {
                         CategoryId = 2,
                        ProductName = "Apple iPhone 15",
                        ProductDescription = "IOS 17, vazn 171g",
                        ProductPrice = 12640000,
                        ProductPicture = @"\images\1_da22d22e-6c4d-469e-8106-cf061096fd01.webp",
                        CreatedAt = DateTime.UtcNow,
                     },
                     new Product
                     {
                         CategoryId = 2,
                        ProductName = "Xiaomi Redmi K50 Gaming 12/256GB",
                        ProductDescription = "76.7x162.5x8.5 mm, akselerometr, giroskop, kompas, rang spektri, Android 12, MIUI 13",
                        ProductPrice = 12640000,
                        ProductPicture = @"\images\0089hSsUgy1gzgcjyqgugj31400u0dli.jpeg",
                        CreatedAt = DateTime.UtcNow,
                     },
                    new Product
                    {
                        CategoryId = 2,
                        ProductName = "Redmi Note 12 Pro 4G (Global)",
                        ProductDescription = "Dual SIM (Nano-SIM, dual stand-by), Android 13, MIUI 14, akselerometr, giroskop, kompas",
                        ProductPrice = 3700200,
                        ProductPicture = @"\images\02a1bf9a-e50f-4cb0-a5ad-29e784d41e34.jpg",
                        CreatedAt = DateTime.UtcNow,
                    },
                    new Product
                    {
                        CategoryId = 1,
                        ProductName = "Acer Aspire 3 A315-59",
                        ProductDescription = "8/512 GB SSD 15.6",
                        ProductPrice = 7684000,
                        ProductPicture = @"\images\2c8780d07005c497a657b7163224d827.webp",
                        CreatedAt = DateTime.UtcNow,
                    },
                    new Product
                    {
                        CategoryId = 3,
                        ProductName = "Monitor Samsung F24T350FHI",
                        ProductDescription = "1920x1080, 75 Gts, 24, ips",
                        ProductPrice = 2567000,
                        ProductPicture = @"\images\monitor-samsung-f24t350fhi-18690-0.jpeg",
                        CreatedAt = DateTime.UtcNow,
                    },
                    new Product
                    {
                        CategoryId = 3,
                        ProductName = "Monitor Pixel PXG27FHD-Pro Gaming Monitor 27",
                        ProductDescription = "IPS, 165 Gts, 27, 1920x1080, 4K, HDMI, DP, USB, Wi-Fi, Bluetooth, VGA, HDMI, DP, USB, Wi-Fi, Bluetooth, VGA, HDMI, DP, USB, Wi-Fi, Bluetooth, VGA, HDMI",
                        ProductPrice = 2817000,
                        ProductPicture = @"\images\monitor-pixel-pxg27fhd-pro-gaming-monitor-27-39305-0.jpeg",
                        CreatedAt = DateTime.UtcNow,
                    },
                    new Product
                    {
                        CategoryId = 4,
                        ProductName = "Simsiz quloqchinlar Marshall Monitor II ANC",
                        ProductDescription = "Quvvatlash vaqti 2 soat, 320gr og'irligi, qora, Bluetooth 5.0",
                        ProductPrice = 4848000,
                        ProductPicture = @"\images\besprovodnye-naushniki-marshall-monitor-ii-anc-115428-0.jpeg",
                        CreatedAt = DateTime.UtcNow,
                    },
                     ];
                db.Products.AddRange(transports);
                await db.SaveChangesAsync();
            }
        }
    }
}
