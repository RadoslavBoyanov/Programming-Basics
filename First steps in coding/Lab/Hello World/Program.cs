using System;

namespace  trainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double hsm = h * 100;

            double hsmFreeSpace = (hsm - 100);

            double deskOnOrder = hsmFreeSpace / 70;

            



            //Console.WriteLine($"{deskOnOrder:F0}");
        }
    }
}
