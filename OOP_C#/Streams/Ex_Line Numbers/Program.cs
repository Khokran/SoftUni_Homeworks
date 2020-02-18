using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string outputPath = "output.txt";
            string[] textLines = File.ReadAllLines(textPath);

            int lineCounter = 1;

            foreach (var currLine in textLines)
            {
                int lettersCount = currLine.Count(char.IsLetter);
                int puncsCount = currLine.Count(char.IsPunctuation);
                File.AppendAllText(outputPath, contents: $"Line {lineCounter}: {currLine} ({lettersCount})({puncsCount}){Environment.NewLine}");
                lineCounter++;
            }
        }
    }
}
