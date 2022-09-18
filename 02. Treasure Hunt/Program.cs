using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Huntt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initianal = new List<string>(Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries));
            List<string> stolen = new List<string>();

            double sum = 0;
            string input = Console.ReadLine();
            while (input!= "Yohoho!")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                if (command == "Loot")
                {
                    for (int i = 1; i < inputArr.Length; i++)
                    {
                        if (!initianal.Contains(inputArr[i]))
                        {
                            initianal.Insert(0, inputArr[i]);
                        }
                    }
                }
                if (command == "Drop")
                {
                    int index = int.Parse(inputArr[1]);
                    if (index >= 0 & index < initianal.Count)
                    {
                        string cur = initianal[index];
                        initianal.RemoveAt(index);
                        initianal.Add(cur);
                    }
                }
                if (command == "Steal")
                {
                    int count = int.Parse(inputArr[1]);
                    if (count < initianal.Count)
                    {
                        for (int i = initianal.Count - count; i < initianal.Count; i++)
                        {
                            stolen.Add(initianal[i]);
                        }
                        Console.WriteLine(string.Join(", ", stolen));
                        stolen.Clear();

                        initianal.RemoveRange(initianal.Count - count, count);
                    }
                    else
                    {
                        for (int i = 0; i < initianal.Count; i++)
                        {
                            stolen.Add(initianal[i]);
                        }

                        Console.WriteLine(string.Join(", ", stolen));

                        stolen.Clear();

                        initianal.RemoveRange(0, initianal.Count);

                    }
                }


                input = Console.ReadLine();
            }
            if (initianal.Count != 0)
            {
                double currSum = 0;
                int counter = 0;

                for (int i = 0; i < initianal.Count; i++)
                {
                    currSum += initianal[i].Length;
                    counter++;
                }

                sum = currSum / counter;

               
                Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");

            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
               
            }

        }
    }
}