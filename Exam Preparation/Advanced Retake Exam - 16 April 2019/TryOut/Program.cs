using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Trojan_Invasion
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());

            var plates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var warriors = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                int[] trojans = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                AddWarriors(warriors, trojans);

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plates.Add(newPlate);
                }

                //   Console.WriteLine(string.Join(", ",plates));

                if (plates.Count != 0)
                {
                    while (plates.Count != 0 && warriors.Count != 0)
                    {
                        int currentDef = plates[0];
                        //   Console.WriteLine(currentDef);
                        int currentAtt = warriors.Pop();
                        //  Console.WriteLine(currentAtt);

                        if (currentDef > currentAtt)
                        {
                            currentDef -= currentAtt;

                            plates[0] = currentDef;
                        }
                        else if (currentDef < currentAtt)
                        {
                            currentAtt -= currentDef;
                            plates.RemoveAt(0);
                            warriors.Push(currentAtt);
                        }
                        else
                        {
                            plates.RemoveAt(0);
                        }
                    }

                    if (plates.Count == 0)
                    {

                        Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                        Console.WriteLine("Warriors left: " + string.Join(", ", warriors));
                        break;
                    }
                }
            }

            if (plates.Count != 0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine("Plates left: " + string.Join(", ", plates));
            }
            else if (plates.Count == 0)
            { 

                Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                Console.WriteLine("Warriors left: " + string.Join(", ", warriors));
            }

        }

        private static void AddWarriors(Stack<int> warriors, int[] trojans)
        {
            foreach (var item in trojans)
            {
                warriors.Push(item);
            }
        }
    }
}
