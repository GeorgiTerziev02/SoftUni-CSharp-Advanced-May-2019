using System;
using System.Linq;

namespace _01._The_Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] garden = new char[n][];

            for (int row = 0; row < n; row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                garden[row] = new char[currentRow.Length];
                garden[row] = currentRow;
            }

            int carrots = 0;
            int lettuce = 0;
            int potatoes = 0;
            int harmed = 0;

            string command = Console.ReadLine();

            while (command != "End of Harvest")
            {
                string[] currentCommand = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = currentCommand[0];

                if (action == "Harvest")
                {
                    int row = int.Parse(currentCommand[1]);
                    int col = int.Parse(currentCommand[2]);

                    if (IsValid(garden, row, col))
                    {
                        char vegetable = garden[row][col];
                        if (vegetable == 'P')
                        {
                            potatoes++; garden[row][col] = ' ';
                        }
                        else if (vegetable == 'C')
                        {
                            carrots++; garden[row][col] = ' ';
                        }
                        else if (vegetable == 'L')
                        {
                            lettuce++; garden[row][col] = ' ';
                        }
                        //garden[row][col] = ' ';
                    }
                }
                else if (action == "Mole")
                {
                    int row = int.Parse(currentCommand[1]);
                    int col = int.Parse(currentCommand[2]);
                    string direction = currentCommand[3];

                    if (IsValid(garden, row, col))
                    {

                        char vegetable = garden[row][col];
                        while (IsValid(garden, row, col))
                        {
                            if (garden[row][col] == 'P' || garden[row][col] == 'L' || garden[row][col] == 'C')
                            {
                                harmed++;
                            }
                            garden[row][col] = ' ';

                            switch (direction)
                            {
                                case "up": row = row - 2; break;
                                case "down": row = row + 2; break;
                                case "right": col = col + 2; break;
                                case "left": col = col - 2; break;
                            }


                        }
                    }
                }

                command = Console.ReadLine();
            }

            foreach (char[] row in garden)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            //Carrots: 4
            //Potatoes: 1
            //Lettuce: 1
            //Harmed vegetables: 1

            Console.WriteLine($"Carrots: {carrots}");
            Console.WriteLine($"Potatoes: {potatoes}");
            Console.WriteLine($"Lettuce: {lettuce}");
            Console.WriteLine($"Harmed vegetables: {harmed}");

        }

        private static bool IsValid(char[][] garden, int row, int col)
        {
            bool b = true;
            int i = -1;
            foreach (char[] rows in garden)
            {
                i++;
                if (i == row)
                {
                    if (col >= rows.Length)
                    {
                        b = false;
                        break;
                    }
                }
            }

            if (row >= garden.GetLength(0))
            {
                b = false;
            }
            if (row < 0 || col < 0)
            {
                b = false;
            }

            return b;
        }
    }
}
