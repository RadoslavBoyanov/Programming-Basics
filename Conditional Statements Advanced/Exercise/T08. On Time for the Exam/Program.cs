using System;

namespace T08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourOnExam = int.Parse(Console.ReadLine());
            int minutesOnExam = int.Parse(Console.ReadLine());
            int hourOnArrival = int.Parse(Console.ReadLine());
            int minutesOnArrival = int.Parse(Console.ReadLine());

            double exam = (hourOnExam * 60) + minutesOnExam;
            double arrival = (hourOnArrival * 60) + minutesOnArrival;

            if (hourOnExam == 0)
            {
                hourOnExam += 24;
            }

            if (exam < arrival)
            {
                Console.WriteLine("Late");
                if (arrival - exam >= 60 && (arrival - exam) %60 >=10 || arrival - exam >= 60 && (arrival - exam) % 60 < 10 || arrival - exam == 60 && (arrival - exam) % 60 == 0)
                {
                    if (arrival - exam >= 60 && (arrival - exam) % 60 >= 10)
                    {
                        Console.WriteLine($"{Convert.ToInt32(arrival - exam) / 60}:{(arrival - exam) % 60} hours after the start");
                    }
                    else if (arrival - exam >= 60 && (arrival - exam) % 60 < 10)
                    {
                        Console.WriteLine($"{Convert.ToInt32(arrival - exam) / 60}:0{(arrival - exam) % 60} hours after the start");
                    }
                    else if (arrival - exam == 60 && (arrival - exam) % 60 == 0)
                    {
                        Console.WriteLine($"{Convert.ToInt32(arrival - exam) / 60}:0{(arrival - exam) % 60} hours after the start");
                    }
                }
                else if (arrival - exam < 60)
                {
                    Console.WriteLine($"{(arrival - exam) % 60} minutes after the start");
                }
            }

            if (exam - arrival >= 0 && exam - arrival <=30)
            {
                Console.WriteLine("On time");
                if (exam - arrival > 0)
                {
                    Console.WriteLine($"{exam - arrival} minutes before the start");
                }
            }

            if (exam - arrival > 30)
            {
                Console.WriteLine("Early");
                if (exam - arrival >= 60 && (exam - arrival) % 60 >= 10 || exam - arrival >= 60 && (exam - arrival) % 60 < 10 || exam - arrival == 60 && (exam - arrival) % 60 == 0)
                {
                    if (exam - arrival >= 60 && (exam - arrival) % 60 >= 10)
                    {
                        Console.WriteLine($"{Convert.ToInt32(exam - arrival) / 60}:{(exam - arrival) % 60} hours before the start");
                    }
                    else if (exam - arrival >= 60 && (exam - arrival) % 60 <10)
                    {
                        Console.WriteLine($"{Convert.ToInt32(exam - arrival) / 60}:0{(exam - arrival) % 60} hours before the start");
                    }
                    else if (exam - arrival == 60 && (exam - arrival) % 60 == 0)
                    {
                        Console.WriteLine($"{Convert.ToInt32(exam - arrival) / 60}:0{(exam - arrival) % 60} hours before the start");
                    }
                }
                else if (exam - arrival < 60)
                {
                    Console.WriteLine($"{exam - arrival} minutes before the start");
                }
            }
        }
    }
}
