using System;
using System.IO;
using System.Windows.Forms;

namespace NebulaDecryptor
{
    public static class Decryptor
    {
        private static readonly string[] targets = new string[] //places that the nebularun encrypted
        {
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
            Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
            Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads",
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            Environment.GetFolderPath(Environment.SpecialFolder.Favorites)
        };

        public static void DecryptAll(byte[] key, byte[] iv, Action<string> log)
        {
            foreach (var dir in targets)
            {
                if (!Directory.Exists(dir)) continue;

                foreach (var file in Directory.GetFiles(dir, "*.nbl", SearchOption.AllDirectories)) //the popular extension
                {
                    try
                    {
                        string output = file.Replace(".nbl", "");
                        Crypto.DecryptFile(file, output, key, iv);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
        }
    }
}
