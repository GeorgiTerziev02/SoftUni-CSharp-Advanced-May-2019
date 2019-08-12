using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            string command = Console.ReadLine();



            while (command.ToLower() != "end")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        List<string> items = command.Split().Skip(1).ToList();
                        listyIterator = new ListyIterator<string>(items);
                    }
                    else if (command.ToLower() == "print")
                    {
                        listyIterator.Print();
                    }
                    else if(command.ToLower()=="hasnext")
                    {
                        Console.WriteLine(listyIterator.HasNext());
                    }
                    else if(command.ToLower()=="move")
                    {
                        Console.WriteLine(listyIterator.Move()); ;
                    }
                    else if(command.ToLower()=="printall")
                    {
                        foreach (var item in listyIterator)
                        {
                            Console.Write(item+" ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
