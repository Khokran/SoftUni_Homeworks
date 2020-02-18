using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Directory_Traversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileArrey = Directory.GetFiles(".", "*.*");

            var dirInfo = new Dictionary<string, Dictionary<string, double>>();
            var directoryInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = directoryInfo.GetFiles();

            foreach (var currFile in allFiles)
            {
                double size = currFile.Length / 1024d;
                string fileName = currFile.Name;
                string extension = currFile.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }
                if (!dirInfo[extension].ContainsKey(fileName))
                {
                    dirInfo[extension].Add(fileName, size);
                }
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt"; 

            foreach (var (extention, value) in dirInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value))
            {
                File.AppendAllText(path, extention + Environment.NewLine);
                foreach (var (fileName, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path, $"--{fileName} - {Math.Round(size, 3)}kb" + Environment.NewLine);
                }
            }
        }
    }
}
