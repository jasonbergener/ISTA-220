using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application uses Herron's formula to find the area of a triangle.");
            double a = getInput("a");
            double b = getInput("b");
            double c = getInput("c");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (area >= 0.000000001)
                Console.WriteLine($"The area of the triangle is: {area:#.####}");
            else
                Console.WriteLine("The lengths given are impossible for a triangle.");
        }
        private static double getInput(string s)
        {
            double value;
            do
            {
                Console.Write($"Enter a the length of side {s}: ");
                value = double.Parse(Console.ReadLine());
            } while (value <= 0);
            return value;
        }
    }
}
