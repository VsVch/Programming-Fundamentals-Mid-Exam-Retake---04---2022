using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int initianalHelth = 100;
            int initianalBit = 0;
            string[] input = Console.ReadLine().Split("|");
            bool isDeth = false;

            for (int i = 0; i < input.Length; i++)
            {
                string[] comArr = input[i].Split();
                string command = comArr[0];
                int number = int.Parse(comArr[1]);
                if (command == "potion")
                {
                    int cur = initianalHelth;
                    initianalHelth += number;
                    if (initianalHelth > 100)
                    {
                        initianalHelth = 100;
                        Console.WriteLine($"You healed for {100 - cur} hp.");
                        Console.WriteLine($"Current health: {initianalHelth} hp.");

                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {initianalHelth} hp.");
                    }
                }
                else if (command == "chest")
                {
                    initianalBit += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    initianalHelth -= number;
                    if (initianalHelth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        isDeth = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }


            }
            if (!isDeth)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {initianalBit}");
                Console.WriteLine($"Health: {initianalHelth}");
            }
            

        }
    }
}