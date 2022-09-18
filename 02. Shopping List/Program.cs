
using System;
using System.Collections.Generic;
 
namespace _02._Shopping_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allGroceries = new List<string>(Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries));
            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] commandArray = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentCommand = commandArray[0];
                switch (currentCommand)
                {
                    case "Urgent":
                        string item = commandArray[1];
                        if (!allGroceries.Contains(item))
                        {
                            allGroceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        string unnecenssaryItem = commandArray[1];
                        if (allGroceries.Contains(unnecenssaryItem))
                        {
                            allGroceries.Remove(unnecenssaryItem);
                        }
                        break;
                    case "Correct":
                        string oldItem = commandArray[1];
                        string newItem = commandArray[2];
                       
                        if (allGroceries.Contains(oldItem))
                        {
                            int index = allGroceries.IndexOf(oldItem);
                           
                            allGroceries.Remove(oldItem);
                            allGroceries.Insert(index, newItem);
                            
                        }
                        break;
                    case "Rearrange":
                        string rearrangeItem = commandArray[1];
                        if (allGroceries.Contains(rearrangeItem))
                        {
                            allGroceries.Remove(rearrangeItem);
                            allGroceries.Add(rearrangeItem);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", allGroceries));
        }
    }
}


