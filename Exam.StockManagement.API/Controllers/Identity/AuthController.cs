using Exam.StockManagement.Application.Abstractions.IServices;
using Exam.StockManagement.Domain.Entities.DTOs.Auth;
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
        public async Task<IActionResult> SignUp([FromForm] RequestSignUp model)
        {
            var result = await _authService.RegisterUser(model);

            if (result.Email == "501")
            {
                return BadRequest("Parol bir-biriga mos kelmadi.");
            } else if (result.Email == "502")
            {
                return BadRequest("Email oldindan band qilingan.");
            }

            return Ok("User muvaffaqiyatli ro'yxatdan o'tkazildi. Iltimos login qismidan qayta kiriting.");
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] RequestLogin model)
        {
            var result = await _authService.UserExist(model);
            if (result)
            {
                // emailga qarab fayl ochadi.
                // coddan foydalanib bo'lganidan so'ng avtomatik o'chib ketadi.
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Users",
                    $"{model.Email.Remove(model.Email.IndexOf("@"))}.txt");

                await _emailSenderService.SendEmailAsync(model.Email, path);
                return Ok("User Emailiga kod yuborildi. Iltimos tasdiqlash qismidan kodni kiriting.");
            }
            return NotFound("Email topilmadi.");
        }

        [HttpPost]
        public async Task<IActionResult> AcceptUser([FromForm] CheckEmail model)
        {
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Users",
                $"{model.Email.Remove(model.Email.IndexOf("@"))}.txt");

            var result = await _authService.GenerateToken(model, path);
            if (result.Token == "503")
            {
                return BadRequest("User'ga yuborilgan kod bilan to'g'ri kelmadi.");
            } else if (result.Token == "404")
            {
                return StatusCode(404, "User topilmadi.");
            }

            return StatusCode(201, result.Token);
        }
    }
}
