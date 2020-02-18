using System;
using System.IO;
using System.Text;

namespace IO_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("temp");
            File.WriteAllText(@"temp\output.txt", "Това е тестови текст!");
            var files = Directory.GetFiles("temp");
            FileInfo fileInfo = new FileInfo(files[0]);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(File.ReadAllText(fileInfo.FullName));

        }
    }
}
