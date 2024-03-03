namespace Exam.StockManagement.Domain.Exceptions
{
    public class PasswordNotMatchException : Exception
    {
        public PasswordNotMatchException() : base("Password not match") { }
    }
}
