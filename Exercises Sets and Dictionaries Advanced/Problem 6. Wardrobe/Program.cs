using System;
using System.Collections.Generic;

namespace Problem_6._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var colours = new Dictionary<string, Dictionary<string, int>>();

            int numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] currentLine = Console.ReadLine().Split(" -> ",StringSplitOptions.RemoveEmptyEntries);
                string currentColour = currentLine[0];

                if(!colours.ContainsKey(currentColour))
                {
                    colours[currentColour] = new Dictionary<string, int>();

                    string[] clothes = currentLine[1].Split(",");

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if(!colours[currentColour].ContainsKey(clothes[j]))
                        {
                            colours[currentColour].Add(clothes[j], 1);
                        }
                        else
                        {
                            colours[currentColour][clothes[j]]++;
                        }                               
                    }
                }

                else
                {
                    string[] clothes = currentLine[1].Split(",");

                    for (int j = 0; j < clothes.Length; j++)
                    {
                        if (!colours[currentColour].ContainsKey(clothes[j]))
                        {
                            colours[currentColour].Add(clothes[j], 1);
                        }
                        else
                        {
                            colours[currentColour][clothes[j]]++;
                        }
                    }
                }               
            }

            string[] searchedItem = Console.ReadLine().Split();
            string searchedColour = searchedItem[0];
            string searchedCloth = searchedItem[1];

            foreach (var colour in colours)
            {
                Console.WriteLine($"{colour.Key} clothes:");

                foreach (var cloth in colour.Value)
                {
                    if (searchedColour == colour.Key&&searchedCloth==cloth.Key)
                    { 
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");                    
                    }
                }
            }

        }
    }
}
