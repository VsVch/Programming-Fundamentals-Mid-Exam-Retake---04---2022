using System;
using System.Collections.Generic;

namespace P02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialLoot = new List<string>(Console.ReadLine().Split("|"));
            List<string> stolen = new List<string>();
            string input = Console.ReadLine();
            while (input != "Yohoho!")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];

                if (command == "Loot")
                {
                    for (int i = 1; i < inputArr.Length; i++)
                    {
                        if (!initialLoot.Contains(inputArr[i]))
                        {
                            initialLoot.Insert(0, inputArr[i]);
                        }
                    }
                }
                if (command == "Drop")
                {
                    int index = int.Parse(inputArr[1]);
                    if (index>=0 & index < initialLoot.Count)
                    {
                        string cur = initialLoot[index];
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(cur);
                    }
                }
                if (command == "Steal")
                {
                    int count = int.Parse(inputArr[1]);
                    if (count < initialLoot.Count)
                    {
                        int startStolen = initialLoot.Count - count;
                        for (int i = startStolen; i < initialLoot.Count; i++)
                        {
                            stolen.Add(initialLoot[i]);
                            

                        }
                        Console.WriteLine(string.Join(", ", stolen));
                        stolen.Clear();
                        initialLoot.RemoveRange(startStolen, count);
                    }
                    else
                    {
                        for (int i = 0; i < initialLoot.Count; i++)
                        {
                            stolen.Add(initialLoot[i]);
                        }

                        Console.WriteLine(string.Join(", ", stolen));

                        stolen.Clear();

                        initialLoot.RemoveRange(0, initialLoot.Count);
                    }
                    
                }

                input = Console.ReadLine();
            }

            if (initialLoot.Count> 0)
            {
                int count = 0;
                double average = 0;
                for (int i = 0; i < initialLoot.Count; i++)
                {
                    average += initialLoot[i].Length;
                }
                average = average / initialLoot.Count;
                Console.WriteLine($"Average treasure gain: {average:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
           
        }
    }
}
