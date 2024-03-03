using Exam.StockManagement.Application.Abstractions.IServices;
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
        public async Task<IActionResult> Create(string name)
        {
            var result = await _categoryService.Create(name);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();

            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, string name)
        {
            var result = await _categoryService.Update(id, name);

            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var restult = await _categoryService.Delete(id);
            return Ok("Deleted");
        }
    }
}
