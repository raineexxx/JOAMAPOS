using System;
using System.Security.Cryptography;
using System.Text;

namespace JOAMAPOS.Services
{
    public static class PasswordHasher
    {
        // SHA-256( Salt + Password ) -> uppercase hex (same as the SQL seed)
        public static string Hash(string salt, string password)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(salt + password));
                return BitConverter.ToString(bytes).Replace("-", "");
            }
        }
    }
}