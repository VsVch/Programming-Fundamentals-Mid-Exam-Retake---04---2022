using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> heighborhood = new List<int>(Console.ReadLine().Split("@").Select(int.Parse).ToList());
            string input = Console.ReadLine();
            int lastPosision = 0;
           
            while (input!= "Love!")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                int lenght = int.Parse(inputArr[1]);
                
                {
                    lastPosision += lenght;
                    if (lastPosision > heighborhood.Count-1)
                    {
                        lastPosision = 0;
                    }
                    if (heighborhood[lastPosision] == 0)
                    {
                        Console.WriteLine($"Place {lastPosision} already had Valentine's day.");
                    }
                    else
                    {
                        heighborhood[lastPosision] -= 2;
                        if (heighborhood[lastPosision] == 0)
                        {
                            Console.WriteLine($"Place {lastPosision} has Valentine's day.");
                        }
                    }
                    
                }
                //Console.WriteLine(string.Join(" ", heighborhood));


                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {lastPosision}.");
            if (heighborhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {heighborhood.Count(x=>x>0)} places.");
            }
        }
    }
}
