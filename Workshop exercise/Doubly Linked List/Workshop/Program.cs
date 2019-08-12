using System;

namespace Workshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            var doubly = new DoublyLinkedList<string>();


            doubly.AddLast("3442");
            doubly.AddLast("4542");
            doubly.AddLast("34");
            doubly.AddLast("test");

            foreach (var item in doubly)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(doubly.Contains("2"));
        }
    }
}
