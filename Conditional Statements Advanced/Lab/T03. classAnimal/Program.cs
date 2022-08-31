using System;

namespace T03._classAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfAnimal = Console.ReadLine();

            switch (nameOfAnimal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
