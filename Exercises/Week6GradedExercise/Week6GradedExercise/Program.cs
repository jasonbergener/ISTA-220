using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6GradedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                try
                {
                    Console.Write("Greetings Professor Falken. Shall we play a game?\n" +
                        "Enter 1 for Human Guess. In this game, I will choose a random number between 1 and 100\n" +
                        " and you will try to guess that number. If you are wrong, I will give you a hint and\n" +
                        " you can try again until you get it.\n\n" +
                        "Enter 2 for Computer Guess. In this game, you will choose a number between 1 and 100\n" +
                        " and I will try to guess that number. Each time I am wrong, a process will give me a\n" +
                        " hint and I will try again until I get it.\n\n" +
                        "Enter 3 for Computer Guess 2. In this game, you will choose a number between 1 and 100\n" +
                        " and I will try to guess that number. Instead of a process giving me hints, you will\n" +
                        " provide the hints until I get it.\n>");
                    input = Console.ReadLine();
                    if (input == "Global Thermonuclear War")
                    {
                        Console.WriteLine("Wouldn't you prefer a good game of chess?\n");
                    }
                    else if (int.Parse(input) == 1)
                    {
                            HumanGuess.Run();
                            break;
                    }
                    else if (int.Parse(input) == 2)
                    {
                        ComputerGuess.Run();
                        break;
                    }
                    else if (int.Parse(input) == 3)
                    {
                        ComputerGuess2.Run();
                        break;
                    }
                    else Console.WriteLine("Your value was out of range.\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter only a whole number (no letters or special characters).\n");
                }
            }
        }
    }
}
