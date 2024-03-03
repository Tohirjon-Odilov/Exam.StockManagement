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
        private readonly IEmailSenderService _emailSenderService;
        private readonly IAuthService _authService;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public AuthController(IAuthService authService,
            IEmailSenderService emailSenderService,
            IWebHostEnvironment webHostEnvironment)
        {
            _emailSenderService = emailSenderService;
            _authService = authService;
            _webHostEnvironment = webHostEnvironment;
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
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "code.txt");

                await _emailSenderService.SendEmailAsync(model.Email, path);
                return Ok(result);
            }
            throw new NotFoundException();
        }

        [HttpPost]
        public async Task<IActionResult> AcceptUser(CheckEmail model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "code.txt");
            var result = await _authService.GenerateToken(model, path);
            return Ok(result.Token);
        }
    }
}
