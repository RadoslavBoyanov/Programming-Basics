using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            double failStudents = 0;
            double middleStudents = 0;
            double goodStudents = 0;
            double topStudents = 0;
            double grades = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                grades += grade;
                if (grade < 3)
                {
                    failStudents++;
                }
                else if (grade <= 3.99)
                {
                    middleStudents++;
                }
                else if (grade <= 4.99)
                {
                    goodStudents++;
                }
                else
                {
                    topStudents++;
                }
            }
            double average = grades / countOfStudents;
            double perTop = topStudents / countOfStudents * 100;
            double perGood = goodStudents / countOfStudents * 100;
            double perMid = middleStudents / countOfStudents * 100;
            double perFail = failStudents / countOfStudents * 100;

            Console.WriteLine($"Top students: {perTop:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {perGood:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {perMid:f2}%");
            Console.WriteLine($"Fail: {perFail:F2}%");
            Console.WriteLine($"Average: {average:f2}");
        }
    }
}
