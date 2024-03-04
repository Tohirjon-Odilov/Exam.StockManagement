using DataAnnotationsExtensions;

namespace Exam.StockManagement.Domain.Entities.DTOs
{
    public class UserDTO
    {
        public string? Name { get; set; }
        [Email]
        public string? Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
