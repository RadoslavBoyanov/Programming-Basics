using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTournaments = int.Parse(Console.ReadLine());
            int pointsInRankingFromTheBegining = int.Parse(Console.ReadLine());
            double winTournaments = 0;
            double points = 0;

            for (int i = 1; i <= countTournaments; i++)
            {
                string resultFromTournament = Console.ReadLine();

                switch (resultFromTournament)
                {
                    case "W":
                        points += 2000;
                        winTournaments++;
                        break;
                    case "F":
                        points += 1200;
                        break;
                    case "SF":
                        points += 720;
                        break;
                    default:
                        break;
                }   
            }

            double totalPoints = points + pointsInRankingFromTheBegining;
            double averagePoints = points / countTournaments;
            double percentWinTournaments = winTournaments / countTournaments * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{percentWinTournaments:f2}%");
        }
    }
}
