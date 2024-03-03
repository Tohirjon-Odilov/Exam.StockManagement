namespace Exam.StockManagement.Domain.Entities.DTOs
{
    public class RequestSignUp
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
    }
}
