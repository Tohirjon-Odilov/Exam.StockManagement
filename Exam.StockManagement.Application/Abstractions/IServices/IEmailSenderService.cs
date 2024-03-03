namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IEmailSenderService
    {
        public Task<string> SendEmailAsync(string email, string path);
    }
}
