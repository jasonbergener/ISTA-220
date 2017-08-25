using System;

namespace Week3GradedExercise
{
    class Turkey : Animals
    {
        public Turkey(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "gobble gobble";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Turkey.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1500);
        }
    }
}
