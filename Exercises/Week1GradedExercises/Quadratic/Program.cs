using System;

namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            //input that results in real numbers: a = 5, b = 9, c = 4
            Console.WriteLine("This application solves quadratic equations.");
            Console.WriteLine("Given ax^2 + bx + c = 0");
            double a = GetInput("a");
            double b = GetInput("b");
            double c = GetInput("c");
            double inner = b * b - 4 * a * c;
            if (inner>=0)
            {
                Quadratic(a, b, inner);
            }
            else
            {
                Console.WriteLine("There is no valid solution.");
                //The below code solves for imaginary numbers
                //Complex(a, b, inner);
            }
        }
        private static void Quadratic(double a, double b, double inner)
        {
            double ans1 = ((-1 * b) + Math.Sqrt(inner)) / (2 * a);
            double ans2 = ((-1 * b) - Math.Sqrt(inner)) / (2 * a);
            Console.WriteLine($"The solution is: ({ans1:#.##}, {ans2:#.##})");
        }
        private static void Complex(double a, double b, double inner)
        {
            double ans1 = (-1 * b) / (2 * a);
            double ans2 = Math.Sqrt(-inner) / (2 * a);
            Console.WriteLine($"The solution is: ({ans1:#.##} + i{ans2:#.##}, {ans1:#.##} - i{ans2:#.##})");
        }
        private static double GetInput(string s)
        {
            do
            {
                Console.Write($"Enter a value for {s}: ");
                try
                {
                    double value = double.Parse(Console.ReadLine());
                    return value;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please use only numbers.");
                }
            } while (true);
        }
    }
}
