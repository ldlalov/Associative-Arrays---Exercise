using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] cmd = input.Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string courseName = cmd[0];
                string studentName = cmd[1];
                if (CourseExist(courses, courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName,new List<string> {studentName});
                }
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.WriteLine($"-- {String.Join("\n-- ", course.Value)}");
            }
            static bool CourseExist(Dictionary<string, List<string>> courses, string courseName)
            {
                if (courses.ContainsKey(courseName))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
