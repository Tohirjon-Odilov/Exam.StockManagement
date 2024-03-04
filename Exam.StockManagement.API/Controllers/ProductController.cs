using Exam.StockManagement.API.Attributes;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpPost]
        [IdentityFilter(Permissions.CreateProduct)]
        public async Task<IActionResult> Create([FromForm] ProductDTO product)
        {
            await productService.Create(product);

            return Ok("Ma'lumot saqlandi");
        }

        [HttpGet]
        [IdentityFilter(Permissions.GetAllProduct)]
        public async Task<IActionResult> GetAll()
        {
            var result = await productService.GetAll();

            return Ok(result);
        }

        [HttpGet]
        [IdentityFilter(Permissions.GetByCategoryProduct)]
        public async Task<IActionResult> GetByCategory([FromForm] string name)
        {
            var result = await productService.GetAll();

            return Ok(result);
        }

        [HttpPut]
        [IdentityFilter(Permissions.UpdateProduct)]
        public async Task<IActionResult> Update([FromForm] ProductDTO product)
        {
            return Ok(await productService.Update(product));
        }

        [HttpDelete]
        [IdentityFilter(Permissions.DeleteProduct)]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            return Ok(await productService.Delete(id));
        }
    }
}
