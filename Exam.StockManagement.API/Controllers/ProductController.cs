using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProductDTO product)
        {
            await productService.Create(product);

            return Ok("Ma'lumot saqlandi");
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await productService.GetAll();

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetByCategory(string name)
        {
            var result = await productService.GetAll();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(ProductDTO product)
        {
            return Ok(await productService.Update(product));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await productService.Delete(id));
        }
    }
}
