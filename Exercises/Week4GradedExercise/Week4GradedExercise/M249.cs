using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class M249 : Weapon
    {
        public override void Shoot()
        {
            Console.WriteLine("Popopopopopopopop");
        }
        public override void Clean()
        {
            Console.WriteLine("Cleaning an M249 is an arduous task due to the intricate moving parts.");
        }
    }
}
