using System;
using System.IO;
using System.Text;

namespace LAB_SREAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string fileName = "input.txt";
            string outputFile = "output.txt";
            string filePath = Path.Combine(path, fileName);

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (var reader = new StreamReader(filePath, Encoding.GetEncoding("windows-1251")))
            {
                int count = 0;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter(Path.Combine(outputFile)))
                {
                    while (line != null)
                    {
                        line = $"{++count}. {line}";
                        Console.WriteLine(line);
                        writer.WriteLine(line);

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
