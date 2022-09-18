

using System;
using System.Collections.Generic;
using System.Linq;
 
namespace P03.SpiceShelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sp = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "done")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                if (cmdType == "AddSpice")
                {
                    string spice = cmdArgs[1];
                    if (!sp.Contains(spice))
                    {
                        sp.Add(spice);
                    }
                }
                else if (cmdType == "AddManySpices")
                {
                    int index = int.Parse(cmdArgs[1]);
                    List<string> spicesToAdd = cmdArgs[2]
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    for (int i = 0; i < spicesToAdd.Count; i++)
                    {
                        sp.Insert(index + i, spicesToAdd[i]);

                    }
                }
                else if (cmdType == "SwapSpices")
                {
                    string spiceOne = cmdArgs[1];
                    string spiceTwo = cmdArgs[2];

                    int indexOne = sp.IndexOf(spiceOne);
                    int indexTwo = sp.IndexOf(spiceTwo);
                    sp.Insert(indexOne, spiceTwo);
                    sp.RemoveAt(indexOne + 1);

                    sp.Insert(indexTwo, spiceOne);
                    sp.RemoveAt(indexTwo + 1);

                }
                else if (cmdType == "ThrowAwaySpices")
                {
                    string spice = cmdArgs[1];
                    int numberOfSpicesToRemove = int.Parse(cmdArgs[2]);

                    if (sp.Contains(spice))
                    {
                        int index = sp.IndexOf(spice);
                        for (int i = 0; i < numberOfSpicesToRemove; i++)
                        {
                            sp.RemoveAt(index);
                        }

                    }
                }
                else if (cmdType == "Arrange")
                {
                    sp.Sort();
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", sp));
        }
    }
}


