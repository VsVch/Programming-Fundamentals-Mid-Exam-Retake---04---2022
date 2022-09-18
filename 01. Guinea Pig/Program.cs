using System;

namespace _01._Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double guineaPigWeight = double.Parse(Console.ReadLine());

            double foodGram = food * 1000;
            double hayGram = hay * 1000;
            double coverGram = cover * 1000;
            double guineaPigWeightGram = guineaPigWeight * 1000;
            
            for (int i = 1; i < 31; i++)
            {
                foodGram -= 300;
                if (i % 2 == 0)
                {
                    
                    hayGram -= 0.05 * foodGram;
                }
                if (i % 3 == 0)
                {
                    coverGram -= guineaPigWeightGram * 0.3333;
                }

            }
            if (foodGram > 0 & hayGram > 0 & coverGram > 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodGram/1000:f2}, Hay: {hayGram/1000:f2}, Cover: {coverGram/ 1000:f2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
        }
    }
}
