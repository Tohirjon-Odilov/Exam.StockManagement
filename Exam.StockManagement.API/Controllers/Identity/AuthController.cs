using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs;
using Exam.StockManagement.Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Exam.StockManagement.API.Controllers.Identity
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RequestSignUp model)
        {
            var result = await _authService.RegisterUser(model);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Login(RequestLogin model)
        {
            var result = await _authService.UserExist(model);
            if (result)
            {
                return Ok(result);
            }
            throw new NotFoundException();
        }

        [HttpPost]
        public async Task<IActionResult> AcceptUser(RequestLogin model)
        {
            var result = await _authService.GenerateToken(model);
            return Ok(result);
        }
    }
}
