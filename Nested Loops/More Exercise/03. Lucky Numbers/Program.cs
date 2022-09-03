using System;

namespace _03._Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 9; i++)
            {

                for (int o = 1; o <= 9; o++)
                {
                    for (int p = 1; p <= 9; p++)
                    {
                        for (int j = 1; j <= 9; j++)
                        {
                            if (i + o == p + j)
                            {
                                if (number % (i + o) == 0 )
                                {
                                    Console.Write($"{i}{o}{p}{j} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
