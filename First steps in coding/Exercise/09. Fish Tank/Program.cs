using System;

namespace _09._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            int longh = int.Parse(Console.ReadLine()); 
            int wildth = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = longh * wildth * hight;
            double volumeInLitres = volume / 1000;
            double busySpace = percent / 100;
            double recLitres = volumeInLitres * (1 - busySpace);

            Console.WriteLine(recLitres);
        }
    }
}
