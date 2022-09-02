using System;

namespace _02._Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int doctors = 7;
            int notReviewedPatients = 0;
            int reviewedPatients = 0;
            
            for (int i = 1; i <= period; i++)
            {
                int patients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (notReviewedPatients > reviewedPatients)
                    {
                        doctors++;
                    }
                }
                if (doctors > patients)
                {
                    reviewedPatients += patients % doctors;
                }
                else if (doctors == patients)
                {
                    reviewedPatients += doctors;
                }
                else { notReviewedPatients += patients - doctors; reviewedPatients += doctors; }
            }

            Console.WriteLine($"Treated patients: {reviewedPatients}.");
            Console.WriteLine($"Untreated patients: {notReviewedPatients}.");
        }
    }
}
