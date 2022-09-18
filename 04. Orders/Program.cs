using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var namePriceQuant = new Dictionary<string, double[]>();

            while (input!="buy")
            {
                string[] inputArr = input.Split().ToArray();
                string product = inputArr[0];
                double price = double.Parse(inputArr[1]);
                double quant = double.Parse(inputArr[2]);
                if (!namePriceQuant.ContainsKey(product))
                {
                    namePriceQuant.Add(product, new double[2]);
                }
                namePriceQuant[product][0] = price;
                namePriceQuant[product][1] += quant;

                input = Console.ReadLine();
            }
            foreach (var item in namePriceQuant)
            {
                Console.WriteLine($"{item.Key} -> {(item.Value[0]*item.Value[1]):f2}");
            }
        }
    }
}
