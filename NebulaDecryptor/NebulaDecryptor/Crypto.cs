using System;
using System.IO;
using System.Security.Cryptography;

namespace NebulaDecryptor
{
    public static class Crypto
    {
        public static byte[] AESDecrypt(byte[] cipherData, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = iv;

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherData, 0, cipherData.Length);
                        cs.FlushFinalBlock();
                    }
                    return ms.ToArray();
                }
            }
        }

        public static void DecryptFile(string inputPath, string outputPath, byte[] key, byte[] iv)
        {
            byte[] encrypted = File.ReadAllBytes(inputPath);
            byte[] decrypted = AESDecrypt(encrypted, key, iv);
            File.WriteAllBytes(outputPath, decrypted);
        }
    }
}
