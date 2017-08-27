using System;
using System.Collections;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (GetInput("Do you want to run Exercise 1, 2, or 3? "))
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                default:
                    Console.WriteLine("That wasn't 1, 2, or 3. Maybe next time.");
                    break;
            }
        }
        private static int GetInput(string s)
        {
            do
            {
                try
                {
                    Console.Write(s);
                    int value = int.Parse(Console.ReadLine());
                    if (value >= 0 && value <= 100)
                    {
                        return value;
                    }
                    else Console.WriteLine("Enter a value between 0 and 100.");
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you entered was not an integer.");
                }
            } while (true);
        }
        private static void Exercise1()
        {
            Console.WriteLine("This Exercise accepts 10 test scores between 0-100 and returns the average score and corresponding letter grade.");
            ArrayList testScores = new ArrayList();
            int testNums = 10;
            for (int i = 0; i < testNums; i++)
            {
                testScores.Add(GetInput("Enter a test score: "));
            }
            Results(testScores);
        }
        private static void Exercise2()
        {
            Console.WriteLine("This Exercise accepts test scores between 0 - 100 and returns the average score and corresponding letter grade.");
            ArrayList testScores = new ArrayList();
            int testNums = GetInput("How many test scores do you want to enter?: ");
            for (int i = 0; i < testNums; i++)
                {
                    testScores.Add(GetInput("Enter a test score: "));
                }
            Results(testScores);
        }
        private static void Exercise3()
        {
            Console.WriteLine("This Exercise accepts test scores between 0-100 and returns the average score and corresponding letter grade.");
            ArrayList testScores = new ArrayList();
            while (true)
            {
                try
                {
                    Console.Write("Enter a score or N to stop: ");
                    string more = Console.ReadLine();
                    if (more.ToLower() == "n")
                        break;
                    else
                    {
                        int value = int.Parse(more);
                        if (value >= 0 && value <= 100)
                        {
                            testScores.Add(value);
                        }
                        else Console.WriteLine("Enter a value between 0 and 100.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The value you entered was invalid.");
                }

            }
            Results(testScores);
        }
        private static void Results(ArrayList a)
        {
            int total = 0;
            int num = 0;
            foreach (int score in a)
            {
                total += score;
                ++num;
            }
            int average = total / num;
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