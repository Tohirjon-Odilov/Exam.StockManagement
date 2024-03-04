using Exam.StockManagement.Application.Abstractions.IServices;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

namespace Exam.StockManagement.Application.Services
{
    public class EmailSenderService : IEmailSenderService
    {
        private readonly IConfiguration _config;

        public EmailSenderService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<string> SendEmailAsync(string email, string path)
        {
            var code = new Random().Next(1000, 9999).ToString();

            IConfigurationSection? emailSettings = _config.GetSection("EmailSettings");
            MailMessage? mailMessage = new MailMessage
            {
                From = new MailAddress(emailSettings["Sender"]!, emailSettings["SenderName"]),
                Subject = "Ro'yhatdan o'tishingiz uchun parol.",
                Body = $"Sizning kodingiz: {code}",
                IsBodyHtml = true,

            };
            mailMessage.To.Add(email!);

            using var smtpClient = new SmtpClient(emailSettings["MailServer"], int.Parse(emailSettings["MailPort"]!))
            {
                Port = Convert.ToInt32(emailSettings["MailPort"]),
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(emailSettings["Sender"], emailSettings["Password"]),
                EnableSsl = true,
            };

            await File.WriteAllTextAsync(path, code);

            await smtpClient.SendMailAsync(mailMessage);
            return code;
        }
    }
}
