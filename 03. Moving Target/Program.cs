using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initanal = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                if (command == "Shoot")
                {
                    int index = int.Parse(inputArr[1]);
                    int power = int.Parse(inputArr[2]);
                    if (index >= 0 & index < initanal.Count)
                    {
                        initanal[index] -= power;
                        if (initanal[index] <= 0)
                        {
                            initanal.RemoveAt(index);
                        }
                    }
                }
                if (command == "Add")
                {
                    int index = int.Parse(inputArr[1]);
                    int value = int.Parse(inputArr[2]);
                    if (index >= 0 & index < initanal.Count)
                    {
                        initanal.Insert(index, value);
                        
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                }
                if (command == "Strike")
                {
                    int index = int.Parse(inputArr[1]);
                    int radius = int.Parse(inputArr[2]);
                    if (index - radius >= 0 && index + radius < initanal[initanal.Count - 1])
                    {
                        initanal.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }

                }
                

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", initanal));
        }
    }
}
