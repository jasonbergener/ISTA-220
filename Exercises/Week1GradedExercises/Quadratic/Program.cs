using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic
{
    class Program
    {
        static void Main(string[] args)
        {
            //input that results in real numbers: a = 5, b = 9, c = 4
            Console.WriteLine("This application solves quadratic equations.");
            Console.WriteLine("Given ax^2 + bx + c = 0");
            double a = getInput("a");
            double b = getInput("b");
            double c = getInput("c");
            double inner = b * b - 4 * a * c;
            if (inner>=0)
            {
                Tuple<double, double> result = quadratic(a, b, inner);
                Console.WriteLine($"The solution is: ({result.Item1:#.##}, {result.Item2:#.##})");
            }
            else
            {
                Console.WriteLine("There is no valid solution.");
                //The below code solves for imaginary numbers
                //Tuple<double, double> imaginary = complex(a, b, inner);
                //Console.WriteLine($"The solution is: ({imaginary.Item1:#.##} + i{imaginary.Item2:#.##}, {imaginary.Item1:#.##} - i{imaginary.Item2:#.##})");
            }
        }
        private static Tuple <double, double> quadratic(double a, double b, double inner)
        {
            double ans1, ans2;
            ans1 = ((-1 * b) + Math.Sqrt(inner)) / (2 * a);
            ans2 = ((-1 * b) - Math.Sqrt(inner)) / (2 * a);
            return new Tuple<double, double>(ans1, ans2);
        }
        private static Tuple<double, double> complex(double a, double b, double inner)
        {
            double ans1, ans2;
            ans1 = (-1 * b) / (2 * a);
            ans2 = Math.Sqrt(-inner) / (2 * a);
            return new Tuple<double, double>(ans1, ans2);
        }
        private static double getInput(string s)
        {
            Console.Write($"Enter a value for {s}: ");
            double value = double.Parse(Console.ReadLine());
            return value;
        }
    }
}
