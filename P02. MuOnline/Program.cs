using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initianal = new List<string>(Console.ReadLine().Split("|").ToList());
            int helth = 100;
            int bitcoins = 0;
            for (int i = 0; i < initianal.Count; i++)
            {
                string[] comArr = initianal[i].Split();
                string command = comArr[0];
                int number = int.Parse(comArr[1]);
                if (command == "potion")
                {
                    int curhelt = helth;
                    helth += number;
                    if (helth > 100)
                    {
                        helth = 100;
                        Console.WriteLine($"You healed for {100 - curhelt} hp.");
                        Console.WriteLine($"Current health: {helth} hp.");
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {helth} hp.");
                    }
                }
                else if  (command == "chest")
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");

                }
                else
                {
                    helth -= number;
                    if (helth > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }





            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {helth}");
        }
    }
}
