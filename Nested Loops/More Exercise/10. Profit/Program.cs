using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int coinOneLev = int.Parse(Console.ReadLine());
            int coinTwoLev = int.Parse(Console.ReadLine());
            int coinFiveLev = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            int total = 0;

            for (int one = 0 ; one <= coinOneLev; one++)
            {
              
                for (int two = 0; two <= coinTwoLev; two++)
                {

                    for (int five = 0; five <= coinFiveLev; five++)
                    {

                        if (one * 1 + two * 2 + five * 5 == sum)
                        {
                            Console.WriteLine($"{one} * 1 lv. + {two} * 2 lv. + {five} * 5 lv. = {sum} lv.");
                        }
                        
                    }
                }
            }

        }
    }
}
