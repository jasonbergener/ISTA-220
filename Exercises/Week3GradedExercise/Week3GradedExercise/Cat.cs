using System;

namespace Week3GradedExercise
{
    class Cat : Animals
    {
        public Cat(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "meow";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Cat.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1300);
        }
    }
}
