using System;

namespace P01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLecture = int.Parse(Console.ReadLine());
            int addBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int maxLecture = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                int stAtendance = int.Parse(Console.ReadLine());
                int curLec = stAtendance;
                double totalBonus = 0;
                totalBonus = stAtendance*1.0 / numberOfLecture * (5 + addBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxLecture = curLec;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxLecture} lectures.");
        }
    }
}
