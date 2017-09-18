using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6GradedExercise
{
    class HumanGuess
    {
        public static void Run()
        {
            int[] list = new int[100];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }
            Random random = new Random();
            int answer = random.Next(1, list.Length);
            int input = -1;
            int start = list[0] - 1;
            int end = list.Length -1;
            int count = 1;
            while (true) //open the infinite loop for user input
            {
                try //try-catch to keep random characters from messing up the program
                {
                    if (list[start] == list[end]) //check to see if there is only one possible answer.
                    {
                        Console.WriteLine($"You narrowed it down to only one possible answer: {answer}.");
                        break; //end the loop
                    }
                    Console.Write($"Enter a number between {list[start]} and {list[end]}: "); //prompt the user
                    input = int.Parse(Console.ReadLine()); //convert string to int
                    if (input < list[start] || input > list[end])
                    {
                        Console.WriteLine("Your answer was out of range.");
                    }
                    else if (input == answer) //check to see the input is right
                    {
                        Console.WriteLine($"Congratulations! {answer} was the right answer!");
                        break; //end the loop
                    }
                    else if (input < answer) //if their input was less than the answer
                    {
                        Console.WriteLine("Your answer was too low.");
                        start = Array.IndexOf(list, input) + 1; //set the beginning of the range to one higher than their last guess
                        count++; //Increment the number of guesses
                    }
                    else if (input > answer) //if their input was greater than the answer
                    {
                        Console.WriteLine("Your answer was too high.");
                        end = Array.IndexOf(list, input) - 1; //set the end of the range to one lower than their last guess
                        count++;
                    }
                }
                catch (Exception) //catches non-int input
                {
                    Console.WriteLine("Please enter only a whole number (no letters or special characters).");
                }
            }
            Console.WriteLine($"The answer was found after {count} tries.");
        }
    }
}
