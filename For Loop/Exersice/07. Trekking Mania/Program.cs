using System;

namespace _07._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGroups = int.Parse(Console.ReadLine());

            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;
            int climbers = 0;

            for (int i = 1; i <= numberOfGroups; i++)
            {
                int countOfPeopleInOneGroup = int.Parse(Console.ReadLine());
                if (countOfPeopleInOneGroup <= 5)
                {
                    musala += countOfPeopleInOneGroup;
                }
                else if (countOfPeopleInOneGroup <= 12)
                {
                    monblan += countOfPeopleInOneGroup;
                }
                else if (countOfPeopleInOneGroup <= 25)
                {
                    kilimandjaro += countOfPeopleInOneGroup;
                }
                else if (countOfPeopleInOneGroup <= 40)
                {
                    k2 += countOfPeopleInOneGroup;
                }
                else
                {
                    everest += countOfPeopleInOneGroup;
                }
                climbers += countOfPeopleInOneGroup;
            }

            double perMusala = musala / climbers * 100;
            double perMonblan = monblan / climbers * 100;
            double perKilimandjaro = kilimandjaro/ climbers * 100;
            double perK2 = k2 / climbers * 100;
            double perEverest = everest / climbers * 100;

            Console.WriteLine($"{perMusala:f2}%");
            Console.WriteLine($"{perMonblan:f2}%");
            Console.WriteLine($"{perKilimandjaro:f2}%");
            Console.WriteLine($"{perK2:f2}%");
            Console.WriteLine($"{perEverest:f2}%");
        }
    }
}
