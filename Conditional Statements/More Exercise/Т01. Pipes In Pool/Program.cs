using System;

namespace Т01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double passedWaterP1 = p1 * h;
            double passedWaterP2 = p2 * h;
            double pipePassedWater = passedWaterP1 + passedWaterP2;

            if (pipePassedWater <= v)
            {
                double percentWaterInPool = pipePassedWater / v * 100;
                double percentWaterFromPipe1 = passedWaterP1 / pipePassedWater * 100;
                double percentWaterFromPipe2 = passedWaterP2 / pipePassedWater * 100;
                Console.WriteLine($"The pool is {percentWaterInPool:f2}% fool. Pipe 1: {percentWaterFromPipe1:f2}%. Pipe 2: {percentWaterFromPipe2:f2}%.");
            }
            else
            {
                double overflowedWater = pipePassedWater - v;
                Console.WriteLine($"For {h} hours the pool overflows with {overflowedWater:f2} liters.");
            }
        }
    }
}
