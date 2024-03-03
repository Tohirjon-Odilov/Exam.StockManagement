using Exam.StockManagement.Domain.Entities.Common;

namespace Exam.StockManagement.Domain.Entities.Models
{
    public class User : Auditable
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string? Code { get; set; }
        public string? Role { get; set; }
    }
}
