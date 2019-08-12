using System;
using System.IO;
using System.Linq;

namespace Problem_2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string textPath = "text.txt";
            string outputPath = "output.txt";

            string[] lines = File.ReadAllLines(textPath);

            int lineCounter = 1;

            foreach (var currentLine in lines)
            {
                int lettersCount = currentLine.Count(char.IsLetter);
                int puncsCount = currentLine.Count(char.IsPunctuation);

                File.AppendAllText(outputPath,$"Line {lineCounter}: -I was quick to judge him, but it wasn't his fault. ({lettersCount})({puncsCount}){Environment.NewLine}");

                lineCounter++;
            }

        }
    }
}
