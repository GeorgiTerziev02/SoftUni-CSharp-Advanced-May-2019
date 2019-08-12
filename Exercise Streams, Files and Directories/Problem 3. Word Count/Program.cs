﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Problem_3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string textPath = "text.txt";
            string wordsPath = "words.txt";

            string[] textLines = File.ReadAllLines(textPath);
            string[] words= File.ReadAllLines(wordsPath);

            var wordsInformation = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string currentWordLower = word.ToLower();
                if(!wordsInformation.ContainsKey(currentWordLower))
                {
                    wordsInformation.Add(word, 0);
                }
            }

            foreach (var currentLine in textLines)
            {
                string[] currentLineWords = currentLine
                    .ToLower()
                    .Split(new char[] { ' ', '-', ',', '?', '.', '\'', '!', ';', ':' });

                foreach (var currentWord in currentLineWords)
                {
                    if(wordsInformation.ContainsKey(currentWord))
                    {
                        wordsInformation[currentWord]++;
                    }
                }

            }

            string actualResultPath = "actualResult.txt";
            string expectedResultPath = "expectedResult.txt";

            foreach (var (key,value) in wordsInformation)
            {
                File.AppendAllText(actualResultPath, $"{key} - {value}{Environment.NewLine}");
            }

            foreach (var (key,value) in wordsInformation.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(expectedResultPath, $"{key} - {value}{Environment.NewLine}");
            }

        }
    }
}
