using System;
using System.Collections.Generic;
using System.Linq;

namespace SummerCocktails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cocktailsDone = new Dictionary<string, int>();
            cocktailsDone.Add("Mimosa", 0);
            cocktailsDone.Add("Mojito", 0);
            cocktailsDone.Add("Sunshine", 0);
            cocktailsDone.Add("Daiquiri", 0);

            int[] ingredientsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] levelsInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> ingredients = new Queue<int>(ingredientsInput);
            Stack<int> freshness = new Stack<int>(levelsInput);

            while (ingredients.Any() && freshness.Any())
            {
                int currentProduct = ingredients.Peek();
                int currentLevel = freshness.Peek();

                if (currentProduct == 0)
                {
                    ingredients.Dequeue();
                    continue;
                }

                int total = currentProduct * currentLevel;

                if (total == 150)
                {
                    cocktailsDone["Mimosa"]++;
                    RemoveElements(ingredients, freshness);
                }
                else if (total == 250)
                {
                    cocktailsDone["Daiquiri"]++;
                    RemoveElements(ingredients, freshness);
                }
                else if (total == 300)
                {
                    cocktailsDone["Sunshine"]++;
                    RemoveElements(ingredients, freshness);
                }
                else if (total == 400)
                {
                    cocktailsDone["Mojito"]++;
                    RemoveElements(ingredients, freshness);
                }
                else
                {
                    RemoveElements(ingredients, freshness);
                    ingredients.Enqueue(currentProduct + 5);
                }
            }

            bool preparedAll = true;
            foreach (var cocktail in cocktailsDone)
            {
                if (cocktail.Value == 0)
                {
                    preparedAll = false;
                    break;
                }
            }

            if (preparedAll)
            {
                Console.WriteLine("It's party time! The cocktails are ready!");
            }
            else
            {
                Console.WriteLine("What a pity! You didn't manage to prepare all cocktails.");
            }

            if (ingredients.Any())
            {
                Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
            }

            foreach (var cocktail in cocktailsDone.OrderBy(c => c.Key))
            {
                if (cocktail.Value != 0)
                {
                    Console.WriteLine($" # {cocktail.Key} --> {cocktail.Value}");
                }
            }
        }

        private static void RemoveElements(Queue<int> ingredients, Stack<int> freshness)
        {
            freshness.Pop();
            ingredients.Dequeue();
        }
    }
}
