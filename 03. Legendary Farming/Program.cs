using System;
using System.Collections.Generic;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            Dictionary<string, int> legend = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();
            legend.Add("shards", 0);
            legend.Add("motes", 0);
            legend.Add("fragments", 0);


            while (!isFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i+=2)
                {
                    string material = input[i].ToLower();
                    int value = int.Parse(input[i-1]);
                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                        legend[material] += value;
                        if (legend[material] >= 250)
                        {
                            isFound = true;
                            break;
                        }
                    }
                    else if (junk.ContainsKey(material))
                    {
                        junk[material] += value;
                    }
                    else
                    {
                        junk.Add(material, value);
                    }

                }


            }
            if (legend["shards"] >= 250)
            {
                Console.WriteLine($"Shadowmourne obtained!");
                legend["shards"] -= 250;
            }
            if (legend["fragments"] >= 250)
            {
                Console.WriteLine($"Valanyr obtained!");
                legend["fragments"] -= 250;
            }
            if (legend["motes"] >= 250)
            {
                Console.WriteLine($"Dragonwrath obtained!");
                legend["motes"] -= 250;
            }
            foreach (var item in legend)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
