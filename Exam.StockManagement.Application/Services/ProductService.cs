using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Models;

namespace Exam.StockManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Create(ProductDTO product)
        {
            ArgumentNullException.ThrowIfNull(product);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", Guid.NewGuid() + "_" + product.ProductPicture.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await product.ProductPicture.CopyToAsync(stream);
            }

            var entity = new Product()
            {
                CategoryId = product.CategoryId,
                ProductDescription = product.ProductDescription,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductPicture = path,
            };

            var result = await productRepository.Create(entity);

            return result;
        }

        public async Task<List<Product>> GetAll()
        {
            ArgumentNullException.ThrowIfNull(productRepository);
            var result = await productRepository.GetAll();
            return result.ToList();
        }
        public async Task<List<Product>> GetByCategory(string categoryName)
        {
            ArgumentNullException.ThrowIfNull(productRepository);
            var datas = await productRepository.GetAll();
            var result = datas.Where(x => x.Category.CategoryName == categoryName);


            return result.ToList();
        }

        public async Task<string> Update(ProductDTO product)
        {
            ArgumentNullException.ThrowIfNull(productRepository);

            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", Guid.NewGuid() + "_" + product.ProductPicture.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await product.ProductPicture.CopyToAsync(stream);
            }

            var entity = new Product()
            {
                CategoryId = product.CategoryId,
                ProductDescription = product.ProductDescription,
                ProductName = product.ProductName,
                ProductPrice = product.ProductPrice,
                ProductPicture = path,
            };

            await productRepository.Update(entity);

            return "Ma'lumot yangilandi";
        }

        public async Task<string> Delete(int Id)
        {
            ArgumentNullException.ThrowIfNull(Id);

            var result = await productRepository.Delete(x => x.Id == Id);


            ArgumentNullException.ThrowIfNull(result);

            return "Muvaffaqiyatli o'chirildi!";
        }
    }
}
