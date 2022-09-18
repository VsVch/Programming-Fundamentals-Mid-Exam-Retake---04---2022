using System;


class Tech_Module
{
    static void Main()
    {
        int dayTrip = int.Parse(Console.ReadLine());
        double budget = double.Parse(Console.ReadLine());
        int peopleInTrip = int.Parse(Console.ReadLine());
        double fuelPerKilometer = double.Parse(Console.ReadLine());
        double foodOnePerson = double.Parse(Console.ReadLine());
        double roomOnePerson = double.Parse(Console.ReadLine());

        if (peopleInTrip > 10)
        {
            roomOnePerson *= 0.75;
        }
        double expenses = dayTrip * peopleInTrip * (foodOnePerson + roomOnePerson);

        for (int i = 1; i <= dayTrip; i++)
        {
            double travelledDistance = double.Parse(Console.ReadLine());
            expenses += travelledDistance * fuelPerKilometer;

            if (i % 3 == 0 || i % 5 == 0)
            {
                expenses *= 1.4;
            }
            if (i % 7 == 0)
            {
                expenses -= expenses / peopleInTrip;
            }

            if (expenses > budget)
            {
                Console.WriteLine($"Not enough money to continue the trip. You need {(expenses - budget):f2}$ more.");
                return;
            }
        }
        Console.WriteLine($"You have reached the destination. You have {(budget - expenses):f2}$ budget left.");
    }
}