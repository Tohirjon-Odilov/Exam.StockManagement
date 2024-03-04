using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.DTOs
{
    public class ProductDTO
    {
        [Required]
        public required string ProductName { get; set; }
        [Required]
        public required int CategoryId { get; set; }
        [Required]
        public required int ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public required IFormFile ProductPicture { get; set; }
    }
}
