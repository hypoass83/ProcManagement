using Application.Interface.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Services.Security
{
    public class EncryptionService : IEncryptionService
    {
       
        public string Encrypt(string text, string key)
        {
            var encrypt = new MyEncrypt(key);
            return encrypt.Encrypt(text);
        }

        public string Decrypt(string text, string key)
        {
            var encrypt = new MyEncrypt(key);
            return encrypt.Decrypt(text);
        }
    }
}
