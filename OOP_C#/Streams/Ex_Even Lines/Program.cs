using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"text.txt";
            string outputFilePath = "result.txt";
            int counter = 0;

            using (var writer = new StreamWriter(outputFilePath))
            {
                using (var streamReader = new StreamReader(textFilePath))
                {
                    string currLine = streamReader.ReadLine();

                    while (currLine != null)
                    {
                        if (counter % 2 == 0)
                        {
                            string replacedSymbols = ReplaceSpecialCharacters(currLine);
                            string reverseWords = ReverseWords(replacedSymbols);
                            writer.WriteLine(reverseWords);
                        }
                        currLine = streamReader.ReadLine();
                        counter++;
                    }
                }
            }
        }
        private static string ReverseWords(string replacedSymbols)
        {
            return string.Join(separator: " ", values: replacedSymbols.Split().Reverse());
        }
        private static string ReplaceSpecialCharacters(string currLine)
        {
            return currLine.Replace(oldValue: "-", newValue: "@")
                           .Replace(oldValue: ",", newValue: "@")
                           .Replace(oldValue: ".", newValue: "@")
                           .Replace(oldValue: "!", newValue: "@")
                           .Replace(oldValue: "?", newValue: "@");
        }
    }
}
