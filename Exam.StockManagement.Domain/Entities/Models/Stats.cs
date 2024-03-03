using Exam.StockManagement.Domain.Entities.Common;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class Stats : BaseEntity
    {
        public int ProductQuantity { get; set; }
        public int ProductCategoryQuantity { get; set; }
        public int ProductSum { get; set; }
        public int ProductCategorySum { get; set; }

        
    }
}
