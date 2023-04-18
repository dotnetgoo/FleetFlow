using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FleetFlow.Service.Helpers
{
    public class PasswordHelper
    {
        public static string Encrypt(string password)
        {
            using(SHA256 sha256HASH = SHA256.Create())
            {
                var hashedBytes = sha256HASH.ComputeHash(Encoding.UTF8.GetBytes(password));

                var hashedPassword = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                return hashedPassword;
            }
        }
    }
}