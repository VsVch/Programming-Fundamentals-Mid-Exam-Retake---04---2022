using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Memory_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int count = 0;

            string command = Console.ReadLine();
            while (command != "end")
            {
                count++;

                string[] indexes = command.Split();
                int num1 = int.Parse(indexes[0]);
                int num2 = int.Parse(indexes[1]);
                if (num1 != num2 & num1 >= 0 & num2 >= 0 & num1 < input.Count & num2 < input.Count)
                {
                    if (input[num1] == input[num2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[num1]}!");

                        if (num1 > num2)
                        {
                            input.RemoveAt(num1);
                            input.RemoveAt(num2);
                        }
                        else
                        {
                            input.RemoveAt(num2);
                            input.RemoveAt(num1);

                        }
                        if (input.Count == 0)
                        {
                            Console.WriteLine($"You have won in {count} turns!");
                            return;
                        }

                    }
                    else if (input[num1] != input[num2])
                    {
                        Console.WriteLine("Try again!");

                    }



                }
                else
                {
                    input.Insert(input.Count / 2, $"-{count}a");
                    input.Insert(input.Count / 2, $"-{count}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }


                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", input));

        }
    }
}
