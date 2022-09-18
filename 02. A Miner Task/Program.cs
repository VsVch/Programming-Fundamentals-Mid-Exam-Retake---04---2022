using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> miner = new Dictionary<string, decimal>();
            string userInput = Console.ReadLine();
            while (userInput != "stop")
            {
                int amount = int.Parse(Console.ReadLine());
                if (miner.ContainsKey(userInput))
                {
                    miner[userInput] += amount;
                }
                
                else
                {
                    miner[userInput] = amount;
                }

              
                userInput = Console.ReadLine();
            }

           
            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}