using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3GradedExercise
{
    class Food
    {
        public string name;
        public int stored;
        public int available;
        public Food(string n, int s, int a)
        {
            this.name = n;
            this.stored = s;
            this.available = a;
        }
    }
}
