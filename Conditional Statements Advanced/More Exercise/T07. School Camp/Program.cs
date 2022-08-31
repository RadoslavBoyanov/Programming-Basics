using System;

namespace T07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int overnightsCount = int.Parse(Console.ReadLine());

            string sport = "";
            double price = 0;

            switch (season)
            {
                case "Winter":
                    if (group == "boys" || group == "girls" || group == "mixed")
                    {
                        if (group == "boys")
                        {
                            sport = "Judo"; 
                            price = overnightsCount * studentsCount * 9.6;
                        }
                        else if (group == "girls")
                        {
                            sport = "Gymnastics";
                            price = overnightsCount * studentsCount * 9.6;
                        }
                        else
                        {
                            sport = "Ski";
                            price = overnightsCount * studentsCount * 10;
                        }
                    }   
                    break;
                case "Spring":
                    if (group == "boys" || group == "girls" || group == "mixed")
                    {
                        if (group == "boys")
                        {
                            sport = "Tennis";
                            price = overnightsCount * studentsCount * 7.20;
                        }
                        else if (group == "girls")
                        {
                            sport = "Athletics";
                            price = overnightsCount * studentsCount * 7.20;
                        }
                        else
                        {
                            sport = "Cycling";
                            price = overnightsCount * studentsCount * 9.50;
                        }
                    }
                    break;
                case "Summer":
                    if (group == "boys" || group == "girls" || group == "mixed")
                    {
                        if (group == "boys")
                        {
                            sport = "Football";
                            price = overnightsCount * studentsCount * 15;
                        }
                        else if (group == "girls")
                        {
                            sport = "Volleyball";
                            price = overnightsCount * studentsCount * 15;
                        }
                        else
                        {
                            sport = "Swimming";
                            price = overnightsCount * studentsCount * 20;
                        }
                    }
                    break;
                default:
                    break;
            }

            if (studentsCount >= 50)
            {
                price *= 0.50;
            }
            else if (studentsCount >= 20)
            {
                price *= 0.85;
            }
            else if (studentsCount >= 10)
            {
                price *= 0.95;
            }
            
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
