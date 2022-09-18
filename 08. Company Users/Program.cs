using System;
using System.Collections.Generic;
using System.Linq;

namespace P08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (!command.Contains("End"))
            {
                string[] commandArr = command.Split(" -> ");
                string company = commandArr[0];
                string employee = commandArr[1];

                if (companies.ContainsKey(company))
                {
                    companies[company].Add(employee);
                }
                else
                {
                    
                    companies.Add(company, new List<string>() { employee });
                }

                command = Console.ReadLine();
            }

            companies = companies.ToDictionary(x => x.Key, x => x.Value);
            companies.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Key}");
                x.Value.ToList().ForEach(e => { Console.WriteLine($"-- {e}"); });
            });
        }
    }
}
