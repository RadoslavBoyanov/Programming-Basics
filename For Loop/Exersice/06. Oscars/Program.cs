using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfActor = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double points = 0;
            double totalPoints = 0;
            
            for (int i = 1; i <= n; i++)
            {
                string nameOfJury = Console.ReadLine();
                double pointFromJury = double.Parse(Console.ReadLine());
                
                points += nameOfJury.Length * pointFromJury / 2;
            }
            totalPoints = points + pointsFromAcademy;
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfActor} you need {1250.5 - totalPoints:f1} more!");
            }
            else
            {
                Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {totalPoints:f1}!");
                
            }
        }
    }
}
