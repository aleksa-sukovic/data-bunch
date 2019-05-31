using System;
using System.Security.Cryptography;

namespace DataBunch.app.foundation.utils
{
    public static class Hash
    {
        public static string make(string data)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(data, salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            var combinedBytes = new byte[36];
            Array.Copy(salt, 0, combinedBytes, 0, 16);
            Array.Copy(hash, 0, combinedBytes, 16, 20);

            return Convert.ToBase64String(combinedBytes);
        }

        public static bool check(string hashValue, string value)
        {
            // parse provided hash value
            var hashBytes = Convert.FromBase64String(hashValue);
            var salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // create hash for value that is checked
            var pbkdf2 = new Rfc2898DeriveBytes(value, salt, 10000);
            var hash = pbkdf2.GetBytes(20);

            // check for math
            for (var i = 0; i < 20; i++) {
                if (hashBytes[i + 16] != hash[i]) {
                    return false;
                }
            }

            return true;
        }
    }
}
