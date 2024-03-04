using DataAnnotationsExtensions;
using Exam.StockManagement.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class User : Auditable
    {
        [Required]
        public string? Name { get; set; }
        [Email]
        [Required]
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string? Code { get; set; }
        public string? Role { get; set; }
    }
}
