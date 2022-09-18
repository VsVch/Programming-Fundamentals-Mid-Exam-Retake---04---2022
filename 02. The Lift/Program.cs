using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleForLift = int.Parse(Console.ReadLine());
            int[] freePlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currPlaces = 0;
            int peopleOnLift = 0;
            bool noMorePeople = false;

            for (int i = 0; i < freePlaces.Length; i++)
            {
                while (freePlaces[i] < 4)
                {
                    freePlaces[i]++;
                    currPlaces++;
                    if (peopleOnLift + currPlaces == peopleForLift)
                    {
                        noMorePeople = true;
                        break;
                    }
                }
                peopleOnLift += currPlaces;
                if (noMorePeople)
                {
                    break;
                }
                currPlaces = 0;
            }

            if (peopleForLift > peopleOnLift)
            {
                Console.WriteLine($"There isn't enough space! {peopleForLift - peopleOnLift} people in a queue!");
                Console.WriteLine(string.Join(" ", freePlaces));
            }
            else if (peopleForLift < freePlaces.Length * 4 && freePlaces.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", freePlaces));
            }
            else if (freePlaces.All(w => w == 4) && noMorePeople == true)
            {
                Console.WriteLine(string.Join(" ", freePlaces));
            }
        }
    }
}
