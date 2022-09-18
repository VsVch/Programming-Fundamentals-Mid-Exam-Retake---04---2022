using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrade = new Dictionary<string, List<double>>();
            string name = string.Empty;
            double grade = 0;
            for (int i = 0; i < n; i++)
            {
                name = Console.ReadLine();
                
                   grade = double.Parse(Console.ReadLine());

                
                if (!studentGrade.ContainsKey(name))
                {
                    studentGrade.Add(name, new List<double>());
                }
                studentGrade[name].Add(grade);

            }
            foreach (var item in studentGrade)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
