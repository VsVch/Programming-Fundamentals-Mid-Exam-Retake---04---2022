using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var ch in input)
            {
                if (!counts.ContainsKey(ch))
                {
                    counts.Add(ch, 1);
                }
                else
                {
                    counts[ch]++;
                }

            }
            foreach (KeyValuePair<char, int> ch in counts.Where(a => a.Key != ' '))
            {
                Console.WriteLine($"{ch.Key} -> {ch.Value}");
            }
        }
    }
}
