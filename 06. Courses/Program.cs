using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, string>();
            var countedCourses = new Dictionary<string, int>();
            string[] input = Console.ReadLine().Split(" : ");
            while (input[0] != "end")
            {
                var courseName = input[0];
                var studentName = input[1];
                if (courses.ContainsValue(courseName) && countedCourses.ContainsKey(courseName))
                {
                    countedCourses[courseName] += 1;
                    courses.Add(studentName, courseName);
                }
                else
                {
                    courses.Add(studentName, courseName);
                    countedCourses.Add(courseName, 1);
                }
                input = Console.ReadLine().Split(" : ");
            }
            foreach (var count in countedCourses)
            {

                Console.WriteLine($"{count.Key}: {count.Value}");
                foreach (var course in courses)
                {
                    if (count.Key == course.Value)
                    {
                        Console.WriteLine($"-- {course.Key}");
                    }
                }

            }
        }
    }
}