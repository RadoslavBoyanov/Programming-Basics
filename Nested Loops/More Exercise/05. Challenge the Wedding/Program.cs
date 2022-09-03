using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int manClients = int.Parse(Console.ReadLine());
            int womenClients = int.Parse(Console.ReadLine());
            int maxQuaTabbles = int.Parse(Console.ReadLine());

            int tabble = 0;

            for (int i = 1; i <= manClients ; i++)
            {
                for (int j = 1; j <= womenClients; j++)
                {
                    tabble++;
                    if (tabble > maxQuaTabbles)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
