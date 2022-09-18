using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int totalLecturs = int.Parse(Console.ReadLine());
            int aditionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            double maxAttendance = 0;
            for (int i = 0; i < numberOfStudents; i++)
            {
                int attendanceOfStudent = int.Parse(Console.ReadLine());
                int curLec = attendanceOfStudent;
                double totalBonus = (totalLecturs * 1.0 * (5 + aditionalBonus));
                totalBonus = (1.0 * attendanceOfStudent) / totalLecturs * (5 + aditionalBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendance = curLec;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling( maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
