using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6GradedExercise
{
    class ComputerGuess
    {
        public static void Run()
        {
            int[] list = new int[100];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }
            int val = -1;
            while (true)
            {
                try
                {
                    Console.Write("Enter a number between 1 and 100: ");
                    val = int.Parse(Console.ReadLine());
                    if (val >= 1 && val <= 100)
                    {
                        Find(val, list);
                        break;
                    }
                    else Console.WriteLine("Your value was out of range.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter only a whole number (no letters or special characters).");
                }
            }
        }
        private static void Find(int v, int[] l)
        {
            int start = l[0] - 1;
            int end = l.Length - 1;
            int mid = l.Length / 2;
            int count = 1;
            while (true)
            {
                if (start == end)
                {
                    Console.WriteLine($"The answer has been narrowed down to only one possible solution: {l[mid]}.");
                    break;
                }
                Console.Write($"The range is between {l[start]} and {l[end]}: ");
                mid = (start + end) / 2;
                Console.WriteLine($"The next guess is {l[mid]}.");
                if (v == l[mid])
                {
                    Console.WriteLine($"I got it! {l[mid]} was the right answer!");
                    break;
                }
                else if (v > l[mid])
                {
                    Console.WriteLine($"{l[mid]} was too low."); //you're too low
                    start = ++mid;
                    count++;
                }
                else if (v < l[mid])
                {
                    Console.WriteLine($"{l[mid]} was too high."); //you're too high
                    end = --mid;
                    count++;
                }
            }
            Console.WriteLine($"The answer was found after {count} tries.");
        }
    }
}
