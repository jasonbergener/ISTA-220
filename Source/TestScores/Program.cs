using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (getInput("Do you want to run Exercise 1, 2, or 3? "))
            {
                case 1:
                    exercise1();
                    break;
                case 2:
                    exercise2();
                    break;
                case 3:
                    exercise3();
                    break;
            }
        }
        private static int getInput(string s)
        {
            int value;

            try
            {
                Console.Write(s);
                value = int.Parse(Console.ReadLine());
                return value;
            }
            catch (Exception)
            {
                Console.WriteLine("The value you entered was not an integer.");
                value = 0;
                return value;
            }
        }
        private static void exercise1()
        {
            Console.WriteLine("This is Exercise 1");
            ArrayList testScores = new ArrayList();
            int testNums = 10;
            for (int i = 0; i < testNums; i++)
            {
                Console.Write("Enter a test score: ");
                try
                {
                    bool valid = false;
                    do
                    {
                        int input = int.Parse(Console.ReadLine());
                        if (input >= 0 && input <= 100)
                        {
                            testScores.Add(input);
                            valid = true;
                        }
                        else Console.Write("Enter a score between 0 and 100: ");
                    } while (valid == false);
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you entered was invalid.");
                }

            }
            int total = 0;
            int num = 0;
            foreach (int score in testScores)
            {
                total += score;
                ++num;
            }
            results(total, num);
        }
        private static void exercise2()
        {
            Console.WriteLine("This is Exercise 2");
            ArrayList testScores = new ArrayList();
            int testNums = getInput("How many test scores do you want to enter?: ");
            for (int i = 0; i < testNums; i++)
            {
                Console.Write("Enter a test score: ");
                try
                {
                    bool valid = false;
                    do
                    {
                        int input = int.Parse(Console.ReadLine());
                        if (input >= 0 && input <= 100)
                        {
                            testScores.Add(input);
                            valid = true;
                        }
                        else Console.Write("Enter a score between 0 and 100: ");
                    } while (valid == false);
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you entered was invalid.");
                }

            }
            int total = 0;
            int num = 0;
            foreach (int score in testScores)
            {
                total += score;
                ++num;
            }
            results(total, num);
        }
        private static void exercise3()
        {
            Console.WriteLine("This is Exercise 3");
            ArrayList testScores = new ArrayList();
            bool done = false;
            Console.Write("Enter the first test score: ");
            while (!done)
            {
                try
                {
                    bool valid = false;
                    do
                    {
                        int input = int.Parse(Console.ReadLine());
                        if (input >= 0 && input <= 100)
                        {
                            testScores.Add(input);
                            valid = true;
                        }
                        else Console.Write("Enter a score between 0 and 100: ");
                    } while (valid == false);
                    Console.Write("Press any key to continue or N to stop.");
                    string more = Console.ReadLine();
                    if (more.ToLower() == "n")
                        done = true;
                    else Console.Write("Enter the next score: ");
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you entered was invalid.");
                }

            }
            int total = 0;
            int num = 0;
            foreach (int score in testScores)
            {
                total += score;
                ++num;
            }
            results(total, num);
        }
        private static void results(int t, int n)
        {
            int average = t / n;
            string grade;
            if (average >= 90)
                grade = "A";
            else if (average >= 80)
                grade = "B";
            else if (average >= 70)
                grade = "C";
            else if (average >= 60)
                grade = "D";
            else
                grade = "F";
            Console.WriteLine($"The average test score is {average}, the grade is {grade}");
        }
    }
}