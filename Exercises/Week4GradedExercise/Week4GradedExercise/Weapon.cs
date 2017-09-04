using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class Weapon : Equipment
    {
        public override void Clean()
        {
            Console.WriteLine("Cleaning a weapon is a task that takes attention to detail.");
        }
        public virtual void Shoot()
        {
            Console.WriteLine($"The {GetType().Name} shoots."); //overrite me.
        }
    }
}
