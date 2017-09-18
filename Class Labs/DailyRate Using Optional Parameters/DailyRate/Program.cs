using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyRate
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            double fee = calculateFee(650,4);
            Console.WriteLine($"Fee is {fee}");
        }
        private double calculateFee(double dailyRate = 500.0, int noOfDays = 1)
        {
            Console.WriteLine("calculateFee using two optional parameters");
            return dailyRate * noOfDays;
        }
        private double calculateFee(double dailyRate = 500.0)
        {
            Console.WriteLine("calculateFee using one optional parameter");

            int defaultNoOfDays = 1;
            return dailyRate * defaultNoOfDays;
        }
        private double calculateFee()
        {
            Console.WriteLine("calculateFee using hardcoded values");
            double defaultDailyRate = 400.0;
            int defaultNoOfDays = 1;
            return defaultDailyRate * defaultNoOfDays;
        }
    }
}
