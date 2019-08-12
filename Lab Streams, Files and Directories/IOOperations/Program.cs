using System;
using System.IO;

namespace IOOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory("temp");
            File.WriteAllText(@"temp\output.txt", "This is a test");
            var files = Directory.GetFiles("temp");
            FileInfo fileInfo = new FileInfo(files[0]);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.Length);
            Console.WriteLine(File.ReadAllText(fileInfo.FullName));

        }
    }
}
