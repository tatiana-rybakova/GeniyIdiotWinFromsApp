using System;
using System.IO;

namespace GeniyIdiot.Common
{
    public class FileOperation
    {
        public static void Add(string path, string data)
        {
            using (StreamWriter writeData = new StreamWriter(path, true))
            {
                writeData.WriteLine(data);
            }
        }

        public static void Replace(string path, string data)
        {
            using (StreamWriter writeData = new StreamWriter(path, false))
            {
                writeData.WriteLine(data);
            }
        }

        internal static bool Exists(string path)
        {
            return File.Exists(path);
        }

        public static string Get(string path)
        {
            using (StreamReader readData = new StreamReader(path))
            {
                return readData.ReadToEnd();
            }
        }

        public static void Clear(string path)
        {
            File.WriteAllText(path, string.Empty);
        }
    }
}

