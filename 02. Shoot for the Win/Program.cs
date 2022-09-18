using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string inputCom = Console.ReadLine();
            int count = 0;
            while (inputCom != "End")
            {
                int index = int.Parse(inputCom);
                if (index >= 0 & index < input.Length)
                {
                    int cur = input[index];
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (input[i] != -1 & i != index)
                        {
                            if (input[i] > cur )
                            {
                                input[i] -= cur;
                            }
                            else if (input[i] <= cur)
                            {
                                input[i] += cur;
                            }
                        }
                    }
                    input[index] = -1;
                    count++;

                }
                



                inputCom = Console.ReadLine();
            }
            Console.Write($"Shot targets: {count} -> ");
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
