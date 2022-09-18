using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double curPrice = 0;
            double allPrice = 0;
            double vat = 0;
            double sumVatVal = 0;
            while (input!= "special" & input!= "regular")
            {
                curPrice = double.Parse(input);
                if (curPrice < 0)
                {
                    Console.WriteLine($"Invalid price!");
                }
                else
                {
                    allPrice += curPrice;
                }

                input = Console.ReadLine();
            }
            if (allPrice == 0)
            {
                Console.WriteLine($"Invalid order!");
                return;
            }
            vat = 0.2 * allPrice;
            sumVatVal = vat + allPrice;
            if (input == "special")
            {
                sumVatVal = sumVatVal - sumVatVal * 0.1;
            }
            Console.WriteLine($"Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {allPrice:f2}$");
            Console.WriteLine($"Taxes: {vat:f2}$");
            Console.WriteLine($"-----------");
            Console.WriteLine($"Total price: {sumVatVal:f2}$");
        }
    }
}
