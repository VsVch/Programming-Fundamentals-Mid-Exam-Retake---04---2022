using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= daysOfPlunder; i++)
            {
                sum += dailyPlunder;
                if (i % 3 == 0)
                {
                    sum += dailyPlunder *.5;
                }
                if (i % 5 == 0)
                {
                    sum -= 0.3 * sum;
                }


            }
            if (sum >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {( ( sum) / expectedPlunder)* 100:f2}% of the plunder.");
            }
        }
    }
}
