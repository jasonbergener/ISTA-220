using System;

namespace Week3GradedExercise
{
    class Rooster : Animals
    {
        public Rooster(string n):base(n)
        {
            this.name = n;
        }
        public override string Sound()
        {
            return "cock-a-doodle-do";
        }
        public override void PlaySound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Environment.CurrentDirectory + "\\Rooster.wav");
            sound.Play();
            System.Threading.Thread.Sleep(1900);
        }
    }
}
