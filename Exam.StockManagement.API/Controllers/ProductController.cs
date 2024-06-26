﻿using Exam.StockManagement.API.Attributes;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(IProductService productService, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            this.productService = productService;
        }

        [HttpPost]
        [AllowAnonymous]
        //[IdentityFilter(Permissions.CreateProduct)]
        public async Task<IActionResult> Create([FromForm] ProductDTO product)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "images", Guid.NewGuid() + "_" + product.ProductPicture.FileName);

            await productService.Create(product, path);

            return Ok("Ma'lumot saqlandi");
        }

        [HttpGet]
        [AllowAnonymous]
        //[IdentityFilter(Permissions.GetAllProduct)]
        public async Task<IActionResult> GetAll()
        {
            var result = await productService.GetAll();

            return Ok(result);
        }

        [HttpPost("{categoryName}")]
        [AllowAnonymous]
        //[IdentityFilter(Permissions.GetByCategoryProduct)]
        public async Task<IActionResult> GetByCategory([Required] string categoryName)
        {
            var result = await productService.GetByCategory(categoryName);

            if (result.Count == 0)
            {
                return StatusCode(404, "Bunday kategoriya mavjud emas!");
            }

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
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await productService.Delete(id));
        }
    }
}
