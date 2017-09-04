using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class InfTeamLeader : Infantry
    {
        public InfTeamLeader(string name, string rank, Weapon weapon = null, Soldier supervisor = null) : base (name, rank, weapon, supervisor)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
            this.Team = "Alpha Team";
        }
        public override void BattleDrillOneA()
        {
            if (this.Team is "Alpha Team")
                Console.WriteLine($"{this.Rank} {this.Name} manuevers {this.Team} on-line to provide covering fire.");
            else
                Console.WriteLine($"{this.Rank} {this.Name} manuevers {this.Team} to flank the enemy.");
        }
    }
}
