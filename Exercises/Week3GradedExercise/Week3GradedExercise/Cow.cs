using System;

namespace Week3GradedExercise
{
    class Cow : Animals
    {
        public Cow(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "moo";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Cow.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1700);
        }
    }
}
