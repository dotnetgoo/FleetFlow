namespace FleetFlow.Shared.Helpers
{
    public class PasswordHelper
    {
        /// <summary>
        /// Hash password 
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string Hash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        /// <summary>
        /// Verify its correct
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordHash"></param>
        /// <returns></returns>
        public static bool Verify(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
