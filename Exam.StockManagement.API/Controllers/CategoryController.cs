using Exam.StockManagement.API.Attributes;
using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        [IdentityFilter(Permissions.CreateCategory)]
        public async Task<IActionResult> Create([FromForm] string name)
        {
            var result = await _categoryService.Create(name);

            return Ok(result);
        }

        [HttpGet]
        [IdentityFilter(Permissions.GetAllCategory)]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();

            return Ok(result);
        }

        [HttpPut]
        [IdentityFilter(Permissions.UpdateCategory)]
        public async Task<IActionResult> Update([FromForm] int id, string name)
        {
            var result = await _categoryService.Update(id, name);

            return Ok(result);
        }

        [HttpDelete]
        [IdentityFilter(Permissions.DeleteCategory)]
        public async Task<IActionResult> Delete([FromForm] int id)
        {
            var restult = await _categoryService.Delete(id);
            return Ok("Deleted");
        }
    }
}
