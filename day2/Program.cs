using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "input.txt";
            string[] lines = File.ReadAllLines(filePath);

            List<(string,int)> commands = new();
            foreach (string line in lines){
                string[] splitted = line.Split();
                (string, int) single = (splitted[0], int.Parse(splitted[1]));
                commands.Add(single);
            }

            commands.ForEach(x => Console.WriteLine("{0}, {1}", x.Item1, x.Item2));

            int aim = 0;
            int pos = 0;
            int depth = 0;
            foreach ((string, int) command in commands){
                _ = command.Item1 switch
                {
                    "forward" => adjustAim(command.Item2, aim, ref pos, ref depth),
                    "down" => aim += command.Item2,
                    "up" => aim -= command.Item2,
                    _ => throw new ArgumentException("Invalid switch"),
                };

                Console.WriteLine("Pos: {0}, Depth: {1}, Aim: {2}",pos, depth, aim);
            }
            Console.WriteLine("Final: Pos: {0}, Depth: {1}, Mult: {2}",pos, depth, pos*depth);
        }

        static int adjustAim(int x, int aim, ref int pos, ref int depth){
            pos += x;
            depth += aim*x;
            return 1;
        }
    }
}
