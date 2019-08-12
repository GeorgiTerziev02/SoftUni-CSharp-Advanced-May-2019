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

            int[] spartans = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var plates = new Queue<int>(spartans);

            for (int i = 1; i <= waves; i++)
            {
                int[] trojans = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                var warriors = new Stack<int>(trojans);

                if (i % 3 == 0)
                {
                    int newPlate = int.Parse(Console.ReadLine());
                    plates.Enqueue(newPlate);
                }


                if (plates.Count != 0)
                {
                    while (plates.Count != 0 && warriors.Count != 0)
                    {
                        int currentDef = plates.Dequeue();
                        int currentAtt = warriors.Pop();

                        if (currentDef > currentAtt)
                        {
                            currentDef -= currentAtt;

                            while (currentDef > 0 && warriors.Count != 0)
                            {
                                currentDef -= warriors.Pop();
                            }
                        }
                        else if (currentDef < currentAtt)
                        {
                            currentAtt -= currentDef;
                            warriors.Push(currentAtt);
                        }
                    }

                    if (plates.Count == 0)
                    {
                        Console.WriteLine("The Trojans successfully destroyed the Spartan defense.");
                        Console.WriteLine("Warriors left: "+ string.Join(", ",warriors));
                        //“Warriors left: {warrior1}, {warrior2}, {warrior3}, (…)”
                    }
                }
            }

            if(plates.Count!=0)
            {
                Console.WriteLine("The Spartans successfully repulsed the Trojan attack.");
                Console.WriteLine("Plates left: "+string.Join(", ",plates));
                //“Plates left: {plate1}, {plate2}, {plate3}, (…)”
            }

        }
    }
}
