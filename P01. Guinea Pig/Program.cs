﻿using System;

namespace P01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine())*1000;
            double hay = double.Parse(Console.ReadLine())*1000;
            double cover = double.Parse(Console.ReadLine())*1000;
            double weight = double.Parse(Console.ReadLine())*1000;

            for (int i = 1; i < 31; i++)
            {

                food -= 300;
                if (food < 0 )
                {
                    break;
                }
                if (i % 2 == 0)
                {
                    hay -= 0.05 * food;
                    if (hay < 0)
                    {
                        break;
                    }
                }
                if (i  % 3 == 0)
                {
                    cover -= 0.3333 * weight;
                    if (cover < 0)
                    {
                        break;
                    }
                }

            }

            if (food < 0 || hay < 0 || cover < 0)
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
            else
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
            }

        }
    }
}
