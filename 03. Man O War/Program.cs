using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateShip = new List<int>(Console.ReadLine().Split(">").Select(int.Parse).ToList());
            List<int> warShip = new List<int>(Console.ReadLine().Split(">").Select(int.Parse).ToList());
            int maxCapacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
           
            int pirateShipSum = 0;
            int warshipSum = 0;
            while (input != "Retire")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                if (command == "Fire")
                {
                    int index = int.Parse(inputArr[1]);
                    int damage = int.Parse(inputArr[2]);
                    if (index >= 0 & index < pirateShip.Count)
                    {
                        warShip[index] -= damage;
                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                if (command == "Defend")
                {
                    int startIndex = int.Parse(inputArr[1]);
                    int endIndex = int.Parse(inputArr[2]);
                    int damage = int.Parse(inputArr[3]);
                    if (startIndex >= 0 & endIndex >= 0 & startIndex < pirateShip.Count & endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine($"You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                        
                    }


                    //Console.WriteLine(string.Join(" ", pirateShip));
                }
                if (command == "Repair")
                {
                    int index = int.Parse(inputArr[1]);
                    int health = int.Parse(inputArr[2]);
                    if (index>= 0 & index< pirateShip.Count)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxCapacity)
                        {
                            pirateShip[index] = maxCapacity;
                        }
                    }
                }
                if (command == "Status")
                {
                    int count = 0;
                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < 0.2*maxCapacity)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine($"{count} sections need repair.");
                }


                input = Console.ReadLine();
            }

            for (int i = 0; i < pirateShip.Count; i++)
            {
                pirateShipSum += pirateShip[i];
            }
            for (int j = 0; j < warShip.Count; j++)
            {
                warshipSum += warShip[j];
            }
            
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            

        }
    }
}
