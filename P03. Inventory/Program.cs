using System;
using System.Collections.Generic;
using System.Linq;

namespace P03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList());
            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] inputArr = input.Split(" - ");
                string command = inputArr[0];
                if (command == "Collect")
                {
                    string item = inputArr[1];
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                if (command == "Drop")
                {
                    string item = inputArr[1];
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                if (command == "Combine Items")
                {
                    string[] items = inputArr[1].Split(":");
                    string oldItem = items[0];
                    string newItem = items[1];
                    if (journal.Contains(oldItem))
                    {
                        int index = journal.IndexOf(oldItem);
                        journal.Insert(index+1,newItem);
                    }
                }
                if (command == "Renew")
                {
                    string item = inputArr[1];
                    if (journal.Contains(item))
                    {
                        string cur = item;
                        journal.Remove(item);
                        journal.Add(item);
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
