namespace Exam.StockManagement.Application.Abstractions.IServices
{
    public interface IHashingPassword
    {
        public bool VerifyPassword(
            string passwordFromUser,
            string hashFromDB,
            string saltAsStringFromDB);
        public string HashPassword(string password, out byte[] salt);
    }
}
