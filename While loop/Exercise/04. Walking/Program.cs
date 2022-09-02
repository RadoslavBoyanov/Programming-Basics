using System;

namespace _04._Walking
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int stepsNeeded = 10000;
            int counterSteps = 0;
            string steps;
            while ((steps = Console.ReadLine()) != "Going home")
            {
                int stepsNum = int.Parse(steps);
                counterSteps += stepsNum;
                if (counterSteps >= stepsNeeded)
                {
                    break;
                }
            }

            if (counterSteps >= stepsNeeded)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{counterSteps - stepsNeeded} steps over the goal!");
            }
            else
            {
                int newSteps = int.Parse(Console.ReadLine());
                counterSteps += newSteps;
                if (counterSteps < stepsNeeded)
                {
                    Console.WriteLine($"{stepsNeeded - counterSteps} more steps to reach goal.");
                }
                else 
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{counterSteps - stepsNeeded} steps over the goal!");
                }
            }
        }
    }
}
