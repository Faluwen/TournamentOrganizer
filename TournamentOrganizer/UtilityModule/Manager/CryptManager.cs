using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace UtilityModule.Manager
{
    public static class CryptManager
    {
        /// <summary>
        /// Passwort-Entschlüsselung
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Decrypt(string text)
        {
            if (text.Length < 1)
            {
                return text;
            }

            string code = "";

            byte[] bytes = Convert.FromBase64String(text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(code, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

            using (MemoryStream ms = new MemoryStream())
            {
                Rijndael alg = Rijndael.Create();
                alg.Key = pdb.GetBytes(32);
                alg.IV = pdb.GetBytes(16);

                using (CryptoStream cs = new CryptoStream(ms, alg.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytes, 0, bytes.Length);
                }

                bytes = ms.ToArray();
            }
            return Encoding.Unicode.GetString(bytes);
        }

        /// <summary>
        /// Passwort-Verschlüsselung
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Encrypt(string text)
        {
            if (text.Length < 1)
            {
                return text;
            }

            string code = "";

            System.Text.UnicodeEncoding enc = new System.Text.UnicodeEncoding();
            byte[] bytes = enc.GetBytes(text);
            PasswordDeriveBytes pdb = new PasswordDeriveBytes(code, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });

            using (MemoryStream ms = new MemoryStream())
            {
                Rijndael alg = Rijndael.Create();
                alg.Key = pdb.GetBytes(32);
                alg.IV = pdb.GetBytes(16);

                using (CryptoStream cs = new CryptoStream(ms, alg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytes, 0, bytes.Length);
                }

                bytes = ms.ToArray();
            }
            return Convert.ToBase64String(bytes);
        }
    }
}
