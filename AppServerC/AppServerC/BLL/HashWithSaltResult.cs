using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppServerC.BLL
{
    class HashWithSaltResult
    {
        public HashWithSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }

        public string Salt { get; }
        public string Digest { get; set; }
    }
}
