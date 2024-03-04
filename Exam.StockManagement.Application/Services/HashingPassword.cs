using Exam.StockManagement.Application.Abstractions.IServices;
using System.Security.Cryptography;
using System.Text;

namespace Exam.StockManagement.Application.Services
{
    public class HashingPassword : IHashingPassword
    {
        private readonly int keySize = 64;
        private readonly int iterations = 350000;
        private readonly HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;

        public string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                salt,
                iterations,
                hashAlgorithm,
                keySize);

            return Convert.ToHexString(hash);
        }

        public bool VerifyPassword(string passwordFromUser, string hashFromDB, string saltAsStringFromDB)
        {
            byte[] salt = Convert.FromHexString(saltAsStringFromDB);

            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(
                password: passwordFromUser,
                salt,
                iterations: iterations,
                hashAlgorithm: hashAlgorithm,
                outputLength: keySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hashFromDB));

        }
    }
}
