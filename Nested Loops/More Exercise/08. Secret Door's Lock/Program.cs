using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int num100 = int.Parse(Console.ReadLine());
            int num10 = int.Parse(Console.ReadLine());
            int num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num100; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 2; j <= num10; j++)
                    {
                        if (j == 2 || j == 3|| j == 5|| j == 7)
                        {
                            for (int k = 1; k <= num1; k++)
                            {
                                if (k % 2 == 0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
               
            }
        }
    }
}
