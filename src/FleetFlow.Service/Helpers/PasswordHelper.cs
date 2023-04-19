using Org.BouncyCastle.Crypto.Generators;

namespace FleetFlow.Service.Helpers
{
    public class PasswordHelper
    {
        public static (string passwordHash, string salt) Hash(string password)
        {
            string salt = Guid.NewGuid().ToString();
            string strongpassword = salt + password;
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(strongpassword);
            return (passwordHash, salt);
        }

        public static bool Verify(string password, string salt, string passwordHash)
        {
            string strongpassword = salt + password;
            var result = BCrypt.Net.BCrypt.Verify(strongpassword, passwordHash);
            return result;
        }
    }
}