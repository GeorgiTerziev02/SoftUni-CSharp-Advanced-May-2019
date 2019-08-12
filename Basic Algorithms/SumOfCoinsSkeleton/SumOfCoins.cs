using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1,2,5};
        var targetSum = 2031154123;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);
        if (selectedCoins.ContainsKey(-1))
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (var selectedCoin in selectedCoins)
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
    }

    public static Dictionary<int, long> ChooseCoins(IList<int> coins, long targetSum)
    {
        var collection = new Dictionary<int, long>();

        while (targetSum > 0)
        {
            bool b = false;
            for (int i = coins.Count - 1; i >= 0; i--)
            {
                long multiplier = 0;
                if (targetSum / coins[i] > 0)
                {
                    multiplier = targetSum / coins[i];
                    targetSum -= coins[i] * multiplier;
                    collection.Add(coins[i], multiplier);
                    b = true;
                }
            }
            if (b == false)
            {
                collection.Add(-1, 0);
                break;
            }
        }

        return collection;
    }
}