using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs.Auth
{
    public class RequestSignUp
    {
        [Required]
        public required string? Name { get; set; }
        [Required]
        [RegularExpression(@"\A[\w!#$%&'*+/=?`{|}~^-]+(?:\.[\w!#$%&'*+/=?`{|}~^-]+)*@↵
(?:[A-Z0-9-]+\.)+[A-Z]{2,6}\Z", ErrorMessage = "Yaroqsiz email kiritildi. Iltimos email manzilini " +
            "to'g'ri kiriting. Email manzil uchun standartlar: @gmail.com, @mail.ru, @yandex.ru, " +
            "@yahoo.com, @outlook.com, @hotmail.com, @bil.om, @mail standartlariga to'g'ri kelsin. Va yoki siz ishlatilishi kerak bo'lmagan belgidan foydalangansiz.")]
        public required string? Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*#?&])[A-Za-z\d@$!%*#?&]{8,}$", ErrorMessage = "Iltimos kuchliroq password kiriting. Kamida Bitta belgi, katta harf, 8 tadan kam bo'lmasin va raqam qatnashsin."
)]
        public required string Password { get; set; }
        [Required]
        public required string ConfirmPassword { get; set; }
        [Required]
        public required string Role { get; set; }
    }
}
