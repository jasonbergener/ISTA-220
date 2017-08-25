using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3GradedExercise
{
    class Human
    {
        public string name;
        public Human(string name)
        {
            this.name = name;
        }
        public void Speak(string say)
        {
            Console.WriteLine($"Hello. My name is {this.name} and I'm a {GetType().Name}. I say \"{say}\".");
        }
        public void Feed(Food food)
        {
            Console.WriteLine($"{this.name} is feeding animals. They started with {food.stored} lbs of {food.name} in storage.");
            --food.stored;
            ++food.available;
            Console.WriteLine($"After feeding, they have {food.stored} lbs of {food.name} in storage" +
                $" and {food.available} lbs of food available to the animals.");
        }
    }
}
