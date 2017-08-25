using System;

namespace Week3GradedExercise
{
    class Pig : Animals
    {
        public Pig(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "oink";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Pig.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1300);
        }
    }
}
