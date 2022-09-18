using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Data;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());
            double fuelPerKilometer = double.Parse(Console.ReadLine());
            double foodOnePerson = double.Parse(Console.ReadLine());
            double priceRoomOnePerson = double.Parse(Console.ReadLine());
            double totalFooDAcomPrice =  days * numberPeople * foodOnePerson +  days * numberPeople * priceRoomOnePerson;
            double totalDayly = 0;
            if (numberPeople > 10)
            {
                totalDayly = 0.75 * totalFooDAcomPrice;
            }
            else
            {
                totalDayly = totalFooDAcomPrice;
            }
            double neededMoney = totalDayly;
            for (int i = 1; i <= days; i++)
            {
                double dailyDistance = double.Parse(Console.ReadLine());
                double fuelExpense = dailyDistance * fuelPerKilometer;
                totalDayly += fuelExpense;
                
                
                if (totalDayly > budjet)
                {
                   
                    
                    Console.WriteLine($"Not enough money to continue the trip. You need {(totalDayly - budjet):f2}$ more.");
                    return;
                }



                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalDayly += totalDayly * 0.4;
                    if (totalDayly > budjet)
                    {


                        Console.WriteLine($"Not enough money to continue the trip. You need {(totalDayly - budjet):f2}$ more.");
                        return;
                    }

                }

                if (i % 7 == 0)
                {
                    double recieveMoney = totalDayly / numberPeople;
                    totalDayly -= recieveMoney;
                   
                    
                }
                

            }
            if (budjet > totalDayly)
            {
                Console.WriteLine($"You have reached the destination. You have {(budjet - totalDayly):f2}$ budget left.");
            }

        }
    }
}
