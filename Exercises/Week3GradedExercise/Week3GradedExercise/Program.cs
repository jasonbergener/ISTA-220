using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3GradedExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoStuff();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void DoStuff()
        {
            Human[] human = new Human[3] { new Human("Old McDonald"), new Human("Jim"), new Human("Bob") };
            Animals[,] animals = new Animals[7, 3]
            {
                {new Cat("Spencer"), new Cat("Kitty"), new Cat("Garfield")}, //Row 0
                {new Cow("Bessie"), new Cow("Steak"), new Cow("Milky")}, //Row 1
                {new Horse("Epona"), new Horse("Mr. Ed"), new Horse("Lighting")}, //Row 2
                {new Pig("Ms. Piggy"), new Pig("Ham"), new Pig("Bacon")}, //Row 3
                {new Puppy("Bo"), new Puppy("Lucy"), new Puppy("Princess")}, //Row 4
                {new Rooster("Alarm"), new Rooster("Loud"), new Rooster("Annoying")}, //Row 5
                {new Turkey("Dinner"), new Turkey("Lunch Meat"), new Turkey("Thanksgiving")} //Row 6
            };
            Food catfood = new Food("cat food", 20, 0);
            Food hay = new Food("hay", 70, 0);
            Food pigslop = new Food("pig slop", 50, 0);
            Food dogfood = new Food("dog food", 30, 0);
            Food seed = new Food("seed", 40, 0);
            human[0].Speak("E-I-E-I-O");
            human[1].Speak("Let's say hello to the animals on the farm.");
            animals[0, 0].Speak();
            animals[1, 0].Speak();
            animals[2, 0].Speak();
            animals[3, 0].Speak("Oh, Kermy! Oh, I've missed you so!");
            animals[4, 0].Speak();
            animals[5, 0].Speak();
            animals[6, 0].Speak();
            animals[0, 1].Speak();
            animals[1, 1].Speak();
            animals[2, 1].Speak("Hello Wilbur");
            animals[3, 1].Speak();
            animals[4, 1].Speak();
            animals[5, 1].Speak();
            animals[6, 1].Speak();
            animals[0, 2].Speak("I love lasagna");
            animals[1, 2].Speak();
            animals[2, 2].Speak();
            animals[3, 2].Speak();
            animals[4, 2].Speak();
            animals[5, 2].Speak();
            animals[6, 2].Speak();
            human[2].Speak("It's time to feed the animals");
            human[0].Feed(catfood); //Feed the cats.
            human[1].Feed(hay); //Feed the cows.
            human[1].Feed(hay); //Feed the horses.
            human[2].Feed(pigslop); //Feed the pigs.
            human[0].Feed(dogfood); //Feed the puppies.
            human[1].Feed(seed); //Feed the roosters.
            human[1].Feed(seed); //Feed the turkeys.
            animals[0, 0].Eat(catfood);
            animals[3, 1].Eat(pigslop);
            animals[4, 0].Eat(dogfood);
            animals[0, 1].Eat(catfood);
        }
    }
}
