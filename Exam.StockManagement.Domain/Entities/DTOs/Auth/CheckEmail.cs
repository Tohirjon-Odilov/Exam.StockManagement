using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class CheckEmail
    {
        [Required]
        [Email]
        public string? Email { get; set; }
        [Required]
        [Length(4, 4)]
        public string? Code { get; set; }
    }
}
