using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCars = int.Parse(Console.ReadLine());
            Dictionary<string, string> nameNumber = new Dictionary<string, string>();
            for (int i = 0; i < numCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                
                if (command == "register")
                {
                    string name = input[1];
                    string plateNumber = input[2];
                    if (!nameNumber.ContainsKey(name))
                    {
                        nameNumber.Add(name, plateNumber);
                        Console.WriteLine($"{name} registered {plateNumber} successfully");
                    }
                    else 
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                    }
                }
                if (command == "unregister")
                {
                    string name = input[1];
                   
                    if (!nameNumber.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        nameNumber.Remove(name);
                    }
                }


            }
            foreach (var item in nameNumber)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
