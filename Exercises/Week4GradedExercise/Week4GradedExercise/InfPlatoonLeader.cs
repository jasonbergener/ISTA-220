using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class InfPlatoonLeader : Infantry
    {
        public InfPlatoonLeader(string name, string rank, Weapon weapon = null, Soldier supervisor = null) : base (name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
        public override void BattleDrillOneA()
        {
            Console.WriteLine($"{this.Rank} {this.Name} orders the squad to conduct a squad assault.");
        }
    }
}
