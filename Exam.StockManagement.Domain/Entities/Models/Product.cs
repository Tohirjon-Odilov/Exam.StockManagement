using Exam.StockManagement.Domain.Entities.Common;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class Product : Auditable
    {
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPicture { get; set; }

        public Category Category { get; set; }
    }
}
