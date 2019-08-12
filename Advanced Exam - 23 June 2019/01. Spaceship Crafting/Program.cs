using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chemicalLiquids = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] physicalItems = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            var liquids = new Queue<int>(chemicalLiquids);
            var items = new Stack<int>(physicalItems);

            var advancedMaterials = new Dictionary<string, int>();
            advancedMaterials.Add("Glass", 0);
            advancedMaterials.Add("Aluminium", 0);
            advancedMaterials.Add("Lithium", 0);
            advancedMaterials.Add("Carbon fiber", 0);

            while (liquids.Count != 0 && items.Count != 0)
            {
                int currentLiquid = liquids.Peek();
                int currentItem = items.Peek();

                //Glass   25
                //Aluminium   50
                //Lithium 75
                //Carbon fiber    100

                if (currentItem + currentLiquid == 25)
                {
                    if (!advancedMaterials.ContainsKey("Glass"))
                    {
                        advancedMaterials.Add("Glass", 0);
                    }
                    advancedMaterials["Glass"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentItem + currentLiquid == 50)
                {
                    if (!advancedMaterials.ContainsKey("Aluminium"))
                    {
                        advancedMaterials.Add("Aluminium", 0);
                    }
                    advancedMaterials["Aluminium"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentItem + currentLiquid == 75)
                {
                    if (!advancedMaterials.ContainsKey("Lithium"))
                    {
                        advancedMaterials.Add("Lithium", 0);
                    }
                    advancedMaterials["Lithium"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 100)
                {
                    if (!advancedMaterials.ContainsKey("Carbon fiber"))
                    {
                        advancedMaterials.Add("Carbon fiber", 0);
                    }
                    advancedMaterials["Carbon fiber"]++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    items.Pop();
                    currentItem += 3;
                    items.Push(currentItem);
                }
            }

            bool enoughMaterials = true;

            foreach (var item in advancedMaterials)
            {
                if (item.Value == 0)
                {
                    enoughMaterials = false;
                    break;
                }
            }

            if (enoughMaterials)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine("Liquids left: " + string.Join(", ", liquids));
            }

            if (items.Count == 0)
            {
                Console.WriteLine("Physical items left: none");
            }
            else
            {
                Console.WriteLine("Physical items left: " + string.Join(", ", items));
            }

            foreach (var material in advancedMaterials.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

        }
    }
}
