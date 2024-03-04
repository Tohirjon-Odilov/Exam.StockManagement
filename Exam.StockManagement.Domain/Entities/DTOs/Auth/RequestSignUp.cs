//using DataAnnotationsExtensions;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class RequestSignUp
    {
        public required string? Name { get; set; }
        //[Email]
        public required string? Email { get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
        public required string Role { get; set; }
    }
}
