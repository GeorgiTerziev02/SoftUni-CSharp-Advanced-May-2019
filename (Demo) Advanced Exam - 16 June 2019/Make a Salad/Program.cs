using System;
using System.Collections.Generic;
using System.Linq;

namespace Make_a_Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vegies = Console.ReadLine().Split();
            int[] cals = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<string> vegetables = new Queue<string>(vegies);
            Stack<int> calories = new Stack<int>(cals);

            while (vegetables.Count != 0 && calories.Count != 0)
            {
                string currentVegetable = vegetables.Dequeue();
                int caloriesWeHave = 0;

                switch (currentVegetable)
                {
                    case "tomato": caloriesWeHave += 80; break;
                    case "carrot": caloriesWeHave += 136; break;
                    case "lettuce": caloriesWeHave += 109; break;
                    case "potato": caloriesWeHave += 215; break;
                }

                int neededCalories = calories.Pop();

                if (neededCalories > caloriesWeHave)
                {
                    while (vegetables.Count != 0 && neededCalories > caloriesWeHave)
                    {
                        string nextVegetable = vegetables.Dequeue();

                        switch (nextVegetable)
                        {
                            case "tomato": caloriesWeHave += 80; break;
                            case "carrot": caloriesWeHave += 136; break;
                            case "lettuce": caloriesWeHave += 109; break;
                            case "potato": caloriesWeHave += 215; break;
                        }
                    }
                }
                if (neededCalories <= caloriesWeHave)
                {
                    Console.Write(neededCalories + " ");
                }
                else Console.Write(neededCalories + " ");
                //greshnno uslovie

            }
            Console.WriteLine();
            if(vegetables.Count!=0)
            {
                Console.WriteLine(string.Join(" ",vegetables));
            }
            else if(calories.Count!=0)
            {
                Console.WriteLine(string.Join(" ",calories));
            }
        }
    }
}
