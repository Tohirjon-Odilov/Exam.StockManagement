using Exam.StockManagement.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class Product : Auditable
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductPicture { get; set; }

        public virtual Category Category { get; set; }
    }
}
