using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initianal = new List<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0].Trim();
                int index = int.Parse(inputArr[1]);
                if (command == "Shoot")
                {
                    int power = int.Parse(inputArr[2]);
                    if (index >= 0 & index < initianal.Count)
                    {
                        initianal[index] -= power;
                        if (initianal[index] <= 0)
                        {
                            initianal.RemoveAt(index);
                        }
                    }
                    //Console.WriteLine(string.Join("|", initianal));
                }
                if (command == "Add")
                {
                    int value = int.Parse(inputArr[2]);
                    if (index >= 0 & index < initianal.Count)
                    {
                        initianal.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid placement!");
                    }
                    //Console.WriteLine(string.Join("|", initianal));
                }
                if (command == "Strike")
                {
                    int radius = int.Parse(inputArr[2]);
                    if (index >= 0 & index < initianal.Count)
                    {
                        if (index - radius >= 0 & index +radius < initianal.Count)
                        {
                            initianal.RemoveRange(index-radius, radius*2+1);
                        }
                        else
                        {
                            Console.WriteLine($"Strike missed!");
                        }
                    }
                    //Console.WriteLine(string.Join("|", initianal));
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", initianal));
        }
    }
}
