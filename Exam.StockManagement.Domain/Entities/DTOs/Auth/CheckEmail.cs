using DataAnnotationsExtensions;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class CheckEmail
    {
        [Email]
        public string Email { get; set; }
        public string Code { get; set; }
    }
}
