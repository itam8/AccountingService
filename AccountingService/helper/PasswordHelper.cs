using System;
using System.Collections.Generic;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace AccountingService.helper
{
    public static class PasswordHelper
    {
        public static string GenerateHash(string password)
        {
            password += ConfigurationManager.AppSettings["SecretKey"];
            var hash = SHA256.HashData(Encoding.UTF8.GetBytes(password));

            return Convert.ToHexString(hash);
        }
    }
}
