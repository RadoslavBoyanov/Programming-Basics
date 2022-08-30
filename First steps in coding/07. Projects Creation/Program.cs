using System;

namespace _07._Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int numOfProjects = int.Parse(Console.ReadLine());

            int sum = numOfProjects * 3;

            Console.WriteLine($"The architect {nameOfArchitect} will need {sum} hours to complete {numOfProjects} project/s.");
        }
    }
}
