using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class StatsController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> GetQuantity()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCategoryQuantity()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetSum()
        {
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetCategorySum()
        {
            return Ok();
        }
    }
}
