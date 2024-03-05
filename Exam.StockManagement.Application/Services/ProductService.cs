using Exam.StockManagement.Application.Abstractions.IRepository;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Models;
using Exam.StockManagement.Domain.Entities.ViewModels;

namespace Exam.StockManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<ProductViewModel> Create(ProductDTO product, string path)
        {
            ArgumentNullException.ThrowIfNull(product);

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
                ProductPicture = path.Split("wwwroot")[1]
            };

            var result = await productRepository.Create(entity);
            var entityResult =
                new ProductViewModel()
                {
                    Id = result.Id,
                    CategoryId = result.CategoryId,
                    ProductName = result.ProductName,
                    ProductDescription = result.ProductDescription,
                    ProductPrice = result.ProductPrice,
                    ProductPicture = result.ProductPicture
                };
            return entityResult;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            ArgumentNullException.ThrowIfNull(productRepository);
            var result = await productRepository.GetAll();

            return result.Select(x =>
            new ProductViewModel()
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                ProductDescription = x.ProductDescription,
                ProductPrice = x.ProductPrice,
                ProductPicture = x.ProductPicture
            }).ToList();
        }
        public async Task<List<ProductViewModel>> GetByCategory(int categoryId)
        {
            ArgumentNullException.ThrowIfNull(productRepository);

            var entity = await productRepository.GetAll();
            var result = entity.Where(x => x.CategoryId == categoryId).ToList();



            return result.Select(x =>
            new ProductViewModel()
            {
                Id = x.Id,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                ProductDescription = x.ProductDescription,
                ProductPrice = x.ProductPrice,
                ProductPicture = x.ProductPicture
            }).ToList();
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
