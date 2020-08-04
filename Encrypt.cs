using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RayMember
{
    class Encrypt
    {
        private string m_pssw;
        public string Init (string a)
        {
            m_pssw = a;
            string hash = Chiffre(m_pssw);
            return hash;
        }
        private string Chiffre(string a)
        {
            using (SHA512 sHA512Hash = SHA512.Create())
            {
                string hash = GetSHA512Hash(sHA512Hash, a);
                return hash;
            }
        }
        private string GetSHA512Hash(SHA512 sHA512Hash, string b)
        {
            byte[] data = sHA512Hash.ComputeHash(Encoding.UTF8.GetBytes(b));
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }

    }
}
