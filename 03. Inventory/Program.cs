using System;
using System.Collections.Generic;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = new List<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
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
                    string[] oldNew = inputArr[1].Split(":",StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = oldNew[0];
                    string newItem = oldNew[1];
                    if (journal.Contains(oldItem))
                    {
                        int inded = journal.IndexOf(oldItem);
                        journal.Insert(inded+1, newItem);
                    }
                }
                if (command == "Renew")
                {
                    string item = inputArr[1];
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                        journal.Insert(journal.Count, item);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
