using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class RequestLogin
    {
        [Required]
        [Email]
        public string Email { get; set; }
        [Required]
        [Length(8, 16)]
        public string Password { get; set; }
    }
}