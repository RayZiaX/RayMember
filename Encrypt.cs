using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace RayMember
{
    class Encrypt
    {
        private string m_pssw;
        private byte[] m_key = Encoding.UTF8.GetBytes("dkjghkjsqghfdjkhgkjhgkjhkhgkjhgf");
        private byte[] m_iV = Encoding.UTF8.GetBytes("dkjghkjsqghfdjkh");
        public string Hash (string a)
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
        public string Encryption(string a)
        {
            string encrypt = Encryptor(a, m_key, m_iV);
            return encrypt;
        }
        public string Decryption(string a)
        {
            string Decrypt = Decrypting(a, m_key, m_iV);
            return Decrypt;
        }
        private string Encryptor(string a, byte[] key, byte[] IV)
        {
            if (a == null || a.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(a);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encrypted);
        }
        private string Decrypting(string a, byte[] key, byte[] IV)
        {
            if (a == null || a.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (key == null || key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] cipheredData = Convert.FromBase64String(a);
            byte[] plainTextData = new byte[cipheredData.Length];
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = IV;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipheredData))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
