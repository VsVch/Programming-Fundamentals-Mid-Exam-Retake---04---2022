using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int allPerHour = first + second + third;
            int hour = 0;

            while (students > 0)
            {
                students -= allPerHour;
                hour++;
                if (hour % 4 == 0)
                {
                    hour++;
                }


            }
           
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
