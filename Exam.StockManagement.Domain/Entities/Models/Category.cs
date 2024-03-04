using System.ComponentModel.DataAnnotations;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
