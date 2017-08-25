using System;

namespace Week3GradedExercise
{
    class Horse : Animals
    {
        public Horse(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "neigh";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Horse.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1700);
        }
    }
}
