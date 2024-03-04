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
    public class StatsController : ControllerBase
    {
        private readonly IStatsService _service;

        public StatsController(IStatsService service)
        {
            _service = service;
        }

        [HttpGet]
        [IdentityFilter(Permissions.GetQuantity)]
        public async Task<IActionResult> GetQuantity()
        {
            var result = await _service.GetQuantity();
            return Ok(result);
        }
        [HttpGet]
        [IdentityFilter(Permissions.GetByCategoryQuantity)]
        public async Task<IActionResult> GetByCategoryQuantity([FromForm] int category_id)
        {
            var result = await _service.GetByCategoryQuantity(category_id);
            return Ok(result);
        }
        [HttpGet]
        [IdentityFilter(Permissions.GetSum)]
        public async Task<IActionResult> GetSum()
        {
            var result = await _service.GetSum();
            return Ok(result);
        }
        [HttpGet]
        [IdentityFilter(Permissions.GetQuantity)]
        public async Task<IActionResult> GetByCategorySum([FromForm] int category_id)
        {
            var result = await _service.GetByCategorySum(category_id);
            return Ok(result);
        }
    }
}
