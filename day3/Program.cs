using System;

namespace App
{
    class Day3
    {
        static void Main(string[] args)
        {
            string filePath = "sample_input.txt";
            string[] lines = File.ReadAllLines(filePath);

            Array.ForEach(lines, x => Console.WriteLine(x));

            List<int> records = lines.Select(x => Int16.Parse(x));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}", 1 << i);

                foreach (int )
            }
        }
    }
}
