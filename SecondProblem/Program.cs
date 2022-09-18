using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Data;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initianal = new List<int>(Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            string input = Console.ReadLine();
            int curPos = 0;
            int point = 0;
            while (input != "Game over")
            {
                string[] inputArr = input.Split("@", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = inputArr[0].Trim();
                if (command == "Shoot Left")
                {
                    int startIndex = int.Parse(inputArr[1].Trim());
                    int length = int.Parse(inputArr[2].Trim());
                    

                    if (startIndex >= 0 & startIndex < initianal.Count)
                    {
                        curPos = startIndex - length;
                        if (curPos < 0)
                        {
                            while (curPos < 0)
                            {
                                curPos += initianal.Count;
                            }
                        }
                        else if (curPos > initianal.Count)
                        {
                            curPos -= initianal.Count;
                        }
                        
                        point += 5;
                        initianal[curPos] -= 5;
                        if (initianal[curPos] < 5)
                        {
                            point += initianal[curPos];
                            initianal[curPos] = 0;
                        }
                    }
                    //Console.WriteLine(string.Join(" - ", initianal));
                }
                if (command == "Shoot Right")
                {
                    int startIndex = int.Parse(inputArr[1].Trim());
                    int length = int.Parse(inputArr[2].Trim());
                    if (startIndex >= 0 & startIndex < initianal.Count)
                    {
                        curPos = length + startIndex;

                        while (curPos >= initianal.Count)
                        {
                            curPos -= initianal.Count;
                        }
                        point += 5;
                        initianal[curPos] -= 5;
                        if (initianal[curPos] < 5)
                        {
                            point += initianal[curPos];
                            initianal[curPos] = 0;
                        }
                    }
                    //Console.WriteLine(string.Join(" - ", initianal));
                }
                if (command == "Reverse")
                {
                    if (initianal.Count > 1)
                    {
                        initianal.Reverse();
                    }
                    

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" - ", initianal));
            Console.WriteLine($"John finished the archery tournament with {point} points!");
        }
    }
}
