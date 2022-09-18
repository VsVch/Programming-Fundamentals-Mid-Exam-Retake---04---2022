using System;

namespace P01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int plunderForDay = int.Parse(Console.ReadLine());
            double expected = double.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= days; i++)
            {
                sum += plunderForDay;
                if (i % 3 == 0)
                {
                    sum += plunderForDay * 0.5;

                }
                if (i % 5 == 0)
                {
                    sum -= sum * 0.3;
                }
            }

            if (sum >= expected)
            {
                Console.WriteLine($"Ahoy! {sum:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {((sum/expected) * 100):f2}% of the plunder.");
            }

        }
    }
}
