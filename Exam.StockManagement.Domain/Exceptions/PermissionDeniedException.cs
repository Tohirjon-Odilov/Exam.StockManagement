namespace Exam.StockManagement.Domain.Exceptions
{
    public class PermissionDeniedException : Exception
    {
        public PermissionDeniedException() : base("Permission denied") { }
    }
}
