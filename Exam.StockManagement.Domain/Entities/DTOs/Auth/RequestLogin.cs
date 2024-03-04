using DataAnnotationsExtensions;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class RequestLogin
    {
        [Email]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}