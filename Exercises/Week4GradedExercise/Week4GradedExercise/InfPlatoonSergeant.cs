using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class InfPlatoonSergeant : Infantry
    {
        public InfPlatoonSergeant(string name, string rank, Weapon weapon = null, Soldier supervisor = null) : base (name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
        public override void BattleDrillOneA()
        {
            Console.WriteLine($"{this.Rank} {this.Name} ensures that any manpower and equipment deficiencies are taken care of.");
        }
    }
}
