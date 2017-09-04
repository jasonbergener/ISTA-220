using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class Infantry : Soldier
    {
        public Infantry(string name, string rank, Weapon weapon = null, Soldier supervisor = null) : base (name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
        public virtual void BattleDrillOneA()
        {
            Console.WriteLine("Default Implementation of Battle Drill 1A."); //Overrite me
        }
    }
}
