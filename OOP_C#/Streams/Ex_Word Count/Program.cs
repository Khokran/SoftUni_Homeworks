using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;

namespace Ex_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";
            string[] textLines = File.ReadAllLines(textPath);
            string[] words = File.ReadAllLines(wordsPath);

            var wordsInfo = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currWordLowerCase = word.ToLower();

                if (!wordsInfo.ContainsKey(currWordLowerCase))
                {
                    wordsInfo.Add(currWordLowerCase, 0);
                }
                foreach (var currLine in textLines)
                {
                    string[] currLineWords = currLine.ToLower().Split(separator: new char[] {' ', '-', ',','?','!','.', ':', ';', '\''});

                    foreach (var currWord in currLineWords)
                    {
                        if (wordsInfo.ContainsKey(currWord))
                        {
                            wordsInfo[currWord]++;
                        }
                    }
                }
                string actionResultPath = "actionResult.txt";
                string expectedResultPath = "expectedResult.txt";

                foreach (var (key, value) in wordsInfo)
                {
                    File.AppendAllText(actionResultPath, contents:$"{key} - {value}{Environment.NewLine}");
                }
                foreach (var (key, value) in wordsInfo.OrderByDescending(x=>x.Value))
                {
                    File.AppendAllText(expectedResultPath, contents: $"{key} - {value}{Environment.NewLine}");
                }
            }
        }
    }
}
