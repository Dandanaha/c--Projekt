using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;


using System.Security.Cryptography;


namespace Hash
{
    public class SHA1
    {
       public static string Hashing (string input) {

            byte[] hash;

            using (var sha1 = new SHA1CryptoServiceProvider())
            {
                hash = sha1.ComputeHash(Encoding.Unicode.GetBytes(input));
            }
            var sb = new StringBuilder();
            foreach (byte b in hash) sb.AppendFormat("{0:x2}", b);
             return sb.ToString();
            }
    }
}
