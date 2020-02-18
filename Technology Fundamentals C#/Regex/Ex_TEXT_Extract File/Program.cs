using System;

namespace Ex_TEXT_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            int startIndexFile = path.LastIndexOf('\\')+1;
            string file = path.Substring(startIndexFile);

            int startIndexExtantion = file.LastIndexOf('.') + 1;
            string nameOfFile = file.Substring(0, startIndexExtantion-1);
            string extantionOfFile = file.Substring(startIndexExtantion);

            Console.WriteLine($"File name: {nameOfFile}");
            Console.WriteLine($"File extension: {extantionOfFile}");
        }
    }
}
