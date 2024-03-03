using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok("Salom");
        }
    }
}
