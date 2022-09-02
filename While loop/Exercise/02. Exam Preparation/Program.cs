using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            double average = 0;
            int countOfExercises = 0;
            int badGradesCount = 0;
            string lastTask = string.Empty;

            string taskName;
            while ((taskName = Console.ReadLine()) != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                
                countOfExercises++;

                if (grade <= 4)
                {
                    badGradesCount++;
                }
                if (badGradesCount == badGrades)
                {
                    break;
                }
                average += grade;
                lastTask = taskName;
            }
            average = (double)average / countOfExercises;
            if (badGradesCount >= badGrades)
            {
                Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {average:F2}");
                Console.WriteLine($"Number of problems: {countOfExercises}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
