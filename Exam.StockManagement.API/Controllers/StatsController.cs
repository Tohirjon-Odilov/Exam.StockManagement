using Exam.StockManagement.Application.Abstractions.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    //[Authorize]
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _service;

        public StatsController(IStatsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetQuantity()
        {
            var result = await _service.GetQuantity();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetByCategoryQuantity(int category_id)
        {
            var result = await _service.GetByCategoryQuantity(category_id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetSum()
        {
            var result = await _service.GetSum();
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetByCategorySum(int category_id)
        {
            var result = await _service.GetByCategorySum(category_id);
            return Ok(result);
        }
    }
}
