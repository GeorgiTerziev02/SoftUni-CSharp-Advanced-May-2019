using System;
using System.IO;
using System.Text;

namespace OutputFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "files";
            string fileName = "input1.txt";
            string outputFile = "output.txt";
            string filePath = Path.Combine(path, fileName);

            using (var reader = new StreamReader(filePath))
            {
                int count = 1;

                string line = reader.ReadLine();

                using (var writer = new StreamWriter (outputFile))
                {
                    while (line != null)
                    {
                        line =$"{count++}. {line}";

                        Console.WriteLine(line);
                        writer.WriteLine(line);

                        line = reader.ReadLine();
                    }
                }

            }
        }
    }
}
