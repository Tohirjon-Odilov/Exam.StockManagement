using Microsoft.AspNetCore.Http;

namespace Exam.StockManagement.Domain.Entities.DTOs
{
    public class ProductDTO
    {
        public required string ProductName { get; set; }
        public required int CategoryId { get; set; }
        public required int ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public required IFormFile ProductPicture { get; set; }
    }
}
