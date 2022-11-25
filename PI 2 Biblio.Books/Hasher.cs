using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace PI_2_Biblio.Books
{
    internal class Hasher
    {
        private static string GenerateHashString(HashAlgorithm algo, string text)
        {
            algo.ComputeHash(Encoding.UTF8.GetBytes(text));

            var result = algo.Hash;

            return string.Join(
                string.Empty,
                result.Select(x => x.ToString("x2"))
            );
        }

        public static string SHA1(string text)
        {
            var result = default(string);

            using (var algo = new SHA1Managed())
            {
                result = GenerateHashString(algo, text);
            }

            return result;
        }
    }
}
