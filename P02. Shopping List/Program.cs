using System;
using System.Collections.Generic;
using System.Linq;

namespace P02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initinal = new List<string>(Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries));
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] inputArr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = inputArr[0];
                if (command == "Urgent")
                {
                    string item = inputArr[1];
                    if (!initinal.Contains(item))
                    {
                        initinal.Insert(0, item);
                    }
                }
                if (command == "Unnecessary")
                {
                    string item = inputArr[1];
                    if (initinal.Contains(item))
                    {
                        initinal.Remove(item);
                    }
                }
                if (command == "Correct")
                {
                    string oldItem = inputArr[1];
                    string newItem = inputArr[2];
                    if (initinal.Contains(oldItem))
                    {
                        int index = initinal.IndexOf(oldItem);
                        initinal.Remove(oldItem);
                        initinal.Insert(index, newItem);
                        

                    }
                }
                if (command == "Rearrange")
                {
                    string item = inputArr[1];
                    if (initinal.Contains(item))
                    {
                        initinal.Remove(item);
                        initinal.Add(item);
                    }
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", initinal));
        }
    }
}
