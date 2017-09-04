using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class Soldier
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public Weapon Weapon { get; set; }
        public Soldier Supervisor { get; set; }
        public List<Equipment> AddEquip = new List<Equipment>();
        public string Team { get; set; }
        public Soldier(string name, string rank, Weapon weapon = null, Soldier supervisor = null)
        {
            this.Name = name;
            this.Rank = rank;
            this.Weapon = weapon;
            this.Supervisor = supervisor;
        }
    }
}
