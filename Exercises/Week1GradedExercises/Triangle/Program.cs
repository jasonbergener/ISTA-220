using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This application uses Herron's formula to find the area of a triangle.");
            double a = GetInput("a");
            double b = GetInput("b");
            double c = GetInput("c");
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            if (area >= 0.000000001)
                Console.WriteLine($"The area of the triangle is: {area:#.####}");
            else
                Console.WriteLine("The lengths given are impossible for a triangle.");
        }
        private static double GetInput(string s)
        {
            double value;
            do
            {
                Console.Write($"Enter a the length of side {s}: ");
                try
                {
                    value = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please use only numbers.");
                    value = -1;
                }
            } while (value <= 0);
            return value;
        }
    }
}
