using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs
{
    public class UserDTO
    {
        //required'larga tekshirdim lekin package'dan qandaydir ogohlantirish bor

        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}
