using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double value;
            do
            {
                Console.WriteLine("This application provides the circumference and area of a circle.");
                Console.Write("Enter the radius of the circle: ");
                value = double.Parse(Console.ReadLine());
            } while (value < 0);

            Console.WriteLine($"The circumference of the circle is: {(2 * Math.PI * value):#.###}");
            Console.WriteLine($"The area of the circle is: {(Math.PI * value * value):#.###}");
        }
    }
}
