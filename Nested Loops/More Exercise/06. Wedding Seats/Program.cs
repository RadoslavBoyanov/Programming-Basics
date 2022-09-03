using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int countRow = int.Parse(Console.ReadLine());
            int numPlacesOnOddRow = int.Parse(Console.ReadLine());
            int quaPlasec = 0;
            int seats = 0;

            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                
                for (int rowsCount = countRow; ; rowsCount++)
                {
                    for (int places = 1; ; places++)
                    {
                        
                        if (places % 2 == 1)
                        {
                            for (char i = 'a'; i <= 'b'; i++)
                            {
                                Console.WriteLine($"{sector}{rowsCount}{i}");
                            }
                        }
                        else
                        {
                            for (char j = 'a'; j <= 'b'; j++)
                            {
                                Console.WriteLine($"{sector}{rowsCount}{j}");
                            }
                        }
                    }
                }
            }
            
        }
    }
}
