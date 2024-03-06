using Exam.StockManagement.Domain.Entities.Common;

namespace Exam.StockManagement.Domain.Entities.ViewModels
{
    public class ProductViewModel : Auditable
    {
        public string? ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProductPicture { get; set; }
        public string? CategoryName { get; set; }
    }
}
