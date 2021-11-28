using System;
using System.IO;


namespace Core.ServiceApp.Utils
{
    public class SaveFiles
    {
        public static void save(string base64file, string path)
        {
            File.WriteAllBytes(path, Convert.FromBase64String(base64file));
        }
    }
}
