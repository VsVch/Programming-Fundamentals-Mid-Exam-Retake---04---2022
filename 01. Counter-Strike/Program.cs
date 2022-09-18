using System;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initianalEnergy = int.Parse(Console.ReadLine());
            int count = 0;
            string input = Console.ReadLine();
            while (input != "End of battle")
            {
                int curEnergy = int.Parse(input);
               
                if (initianalEnergy < curEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {initianalEnergy} energy");
                    return;
                }
                
                initianalEnergy -= curEnergy;
                count++;
                if (count % 3 == 0)
                { initianalEnergy += count; }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {count}. Energy left: {initianalEnergy}");
        }
    }
}
