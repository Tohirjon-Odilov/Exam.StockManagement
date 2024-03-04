using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class RequestSignUp
    {
        [Required]
        public required string? Name { get; set; }
        [Required]
        [Email]
        public required string? Email { get; set; }
        [Required]
        [Length(8, 16)]
        public required string Password { get; set; }
        [Required]
        [Length(8, 16)]
        public required string ConfirmPassword { get; set; }
        [Required]
        public required string Role { get; set; }
    }
}
