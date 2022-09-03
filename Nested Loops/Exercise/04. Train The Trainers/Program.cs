using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfJury = int.Parse(Console.ReadLine());
            double totalAvg = 0;
            string nameOfPresantation = Console.ReadLine();
            int presantation = 0;

            while (nameOfPresantation != "Finish")
            {
                double avg = 0;
                for (int i = 1; i <= numOfJury; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    avg += grade;
                    totalAvg += grade;
                }
                presantation++;
                Console.WriteLine($"{nameOfPresantation} - {avg / numOfJury:f2}.");
                nameOfPresantation = Console.ReadLine();
            }
            double result = totalAvg / (numOfJury * presantation);
            Console.WriteLine($"Student's final assessment is {result:f2}.");
        }
    }
}
