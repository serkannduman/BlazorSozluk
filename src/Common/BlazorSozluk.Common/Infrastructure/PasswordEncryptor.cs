using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Infrastructure
{
    public class PasswordEncryptor
    {
        public static string Encrpt(string password)
        {
            using var md5 = MD5.Create();

            byte[] inputBytes = Encoding.ASCII.GetBytes(password); // asci karakterlerini dönüştürüp byte olarak tutuyoruz.
            byte[] hashBytes = md5.ComputeHash(inputBytes); // burada hashleme işlemi gerçekleştiriyoruz

            return Convert.ToHexString(hashBytes);
        }
    }
}
