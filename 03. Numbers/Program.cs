using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initianal = Console.ReadLine().Split().Select(int.Parse).ToList();
            StringBuilder ans = new StringBuilder();
            int sum = 0;
            double avarege = 0;
            if (initianal.Count <= 1)
            {
                Console.WriteLine($"No");
                return;
            }
            for (int i = 0; i < initianal.Count; i++)
            {
                sum += initianal[i];
            }
            avarege = sum / initianal.Count;
            int match = initianal.Where(x => x > avarege).ToArray().Count();
            if (match == 0)
            {
                Console.WriteLine("No");
            }
            else if (initianal.Count < 5)
            {
                Console.WriteLine($"Less than 5 numbers");
            }
            else
            {
                var result = initianal.OrderByDescending(x => x).Where(x => x > avarege).Take(5).ToArray();
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}
