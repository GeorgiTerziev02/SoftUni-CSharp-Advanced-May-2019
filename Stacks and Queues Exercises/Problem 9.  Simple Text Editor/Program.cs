using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_9.__Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var versions =new Stack<string>();
            var text = new StringBuilder();

            for (int i = 0; i < input; i++)
            {
                string[] currentCommand = Console.ReadLine().Split().ToArray();
                string command = currentCommand[0];

                if(command=="1")
                {
                    versions.Push(text.ToString());
                    string addText = currentCommand[1];
                    text.Append(addText);
                }
                else if(command=="2")
                {
                    versions.Push(text.ToString());
                    int countToRemove = int.Parse(currentCommand[1]);
                    text.Remove(text.Length-countToRemove, countToRemove);
                }
                else if(command=="3")
                {
                    int index = int.Parse(currentCommand[1]);
                    string x = text[index - 1].ToString();
                    Console.WriteLine(x);
                }
                else if(command=="4")
                {
                    text.Clear();
                    text.Append(versions.Pop());
                }

            }

        }
    }
}
