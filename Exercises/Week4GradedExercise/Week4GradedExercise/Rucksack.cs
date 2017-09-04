using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4GradedExercise
{
    class Rucksack : Equipment
    {
        public List<Equipment> Contents = new List<Equipment>();
        public override void Clean()
        {
            Console.WriteLine("To clean a rucksack, disassemble and wash the frame separately.");
        }
    }
}
