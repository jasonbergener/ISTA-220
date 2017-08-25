using System;

namespace Week3GradedExercise
{
    class Puppy : Animals
    {
        public Puppy(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "bark";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Puppy.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1700);
        }
    }
}
