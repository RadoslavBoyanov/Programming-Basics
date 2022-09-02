using System;

namespace _02._Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int badGrades = 0;
            double sum = 0;
            int countOfGrades = 1;
            double average = 0;
            
            while (countOfGrades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4)
                {
                    badGrades++;
                    if (badGrades == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {countOfGrades} grade");
                        break;
                    }
                    grade = double.Parse(Console.ReadLine());
                }
                else
                {
                    countOfGrades++;
                    sum += grade;
                    grade = double.Parse(Console.ReadLine());
                }
            }
            average = sum / 12;

            if (badGrades != 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
