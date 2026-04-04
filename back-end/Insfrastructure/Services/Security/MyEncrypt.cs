using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.Security
{
    public class MyEncrypt
    {
        private readonly TripleDESCryptoServiceProvider _tripleDes;

        public MyEncrypt(string key)
        {
            _tripleDes = new TripleDESCryptoServiceProvider
            {
                Key = TruncateHash(key, _tripleDesKeySize() / 8),
                IV = TruncateHash("", _tripleDesBlockSize() / 8)
            };
        }

        private int _tripleDesKeySize() => 192;
        private int _tripleDesBlockSize() => 64;

        private byte[] TruncateHash(string key, int length)
        {
            using var sha1 = SHA1.Create();

            byte[] keyBytes = Encoding.Unicode.GetBytes(key);
            byte[] hash = sha1.ComputeHash(keyBytes);

            Array.Resize(ref hash, length);
            return hash;
        }

        public string Encrypt(string plaintext)
        {
            byte[] plaintextBytes = Encoding.Unicode.GetBytes(plaintext);

            using var ms = new MemoryStream();
            using var encryptor = _tripleDes.CreateEncryptor();
            using var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write);

            cs.Write(plaintextBytes, 0, plaintextBytes.Length);
            cs.FlushFinalBlock();

            return Convert.ToBase64String(ms.ToArray());
        }

        public string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

            using var ms = new MemoryStream();
            using var decryptor = _tripleDes.CreateDecryptor();
            using var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Write);

            cs.Write(encryptedBytes, 0, encryptedBytes.Length);
            cs.FlushFinalBlock();

            return Encoding.Unicode.GetString(ms.ToArray());
        }
    }
}
