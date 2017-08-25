using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3GradedExercise
{
    class Animals
    {
        public string name;
        public Animals(string n)
        {
            this.name = n;
        }
        public void Speak()
        {
            Console.WriteLine($"Hello. My name is {this.name} and I'm a {GetType().Name}. I say \"{Sound()}\".");
            PlaySound();
        }
        public void Speak(string cust)
        {
            Console.WriteLine($"Hello. My name is {this.name} and I'm a {GetType().Name}. I say \"{cust}\".");
        }
        public void Eat(Food food)
        {
            if (food.available > 0)
            {
                --food.available;
                Console.WriteLine($"{this.name} the {GetType().Name} ate, and now there is {food.available} lbs of {food.name} available to eat.");
            }
            else Console.WriteLine($"There was no {food.name} for {this.name} the {GetType().Name} to eat.");
        }
        public virtual string Sound()
        {
            return "something went wrong"; //Override me please.
        }
        public virtual void PlaySound()
        {
            //Override me please.
        }
    }
}
