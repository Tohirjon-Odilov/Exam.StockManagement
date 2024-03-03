namespace Exam.StockManagement.Domain.Entities.Common
{
    public abstract class Auditable : BaseEntity
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
