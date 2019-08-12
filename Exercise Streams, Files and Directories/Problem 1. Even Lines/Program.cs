using System;
using System.IO;
using System.Linq;

namespace Problem_1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath =@"../../../text.txt";

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                string line = reader.ReadLine();
                int counter = 0;

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSpecialCharacters(line);
                        string reversedWords = ReversedWords(replacedSymbols);

                        Console.WriteLine(reversedWords);
                    }

                    line = reader.ReadLine();

                    counter++;
                }
       
            }

        }

        private static string ReversedWords(string replacedSymbols)
        {
            return string.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacters(string line)
        {
           return line.Replace("-", "@")
                .Replace("?", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@");
        }
    }
}
