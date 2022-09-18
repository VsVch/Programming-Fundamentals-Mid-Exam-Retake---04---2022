using System;
using System.Linq;

namespace _02._Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initianal = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] inputArr = input.Split();
                string command = inputArr[0];
                if (command == "swap")
                {
                    int index1 = int.Parse(inputArr[1]);
                    int index2 = int.Parse(inputArr[2]);
                    int cur = initianal[index1];
                    initianal[index1] = initianal[index2];
                    initianal[index2] = cur;
                }
                if (command == "multiply")
                {
                    int index1 = int.Parse(inputArr[1]);
                    int index2 = int.Parse(inputArr[2]);
                    int multy = initianal[index1] * initianal[index2]; ;
                    initianal[index1] = multy;
                }
                if (command == "decrease")
                {
                    for (int i = 0; i < initianal.Length; i++)
                    {
                        initianal[i]--;
                    }
                }
                



                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", initianal));
        }
    }
}
