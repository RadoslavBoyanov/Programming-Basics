﻿using System;

namespace _10._Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours < 24; hours++)
            {
                for (int minutes = 0; minutes <= 59; minutes++)
                {
                    for (int seconds = 0; seconds <= 59; seconds++)
                    {
                        Console.WriteLine($"{hours} : {minutes} : {seconds}");
                    }
                }
            }
        }
    }
}
