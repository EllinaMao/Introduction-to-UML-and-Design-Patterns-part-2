using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_UML_and_Design_Patterns_part_2
{
    public abstract class Herbivore
    {
        public int Weight { get; protected set; }
        public bool IsAlive { get; set; } = true;
        public Herbivore(int weight = 15)
        {
            Weight = weight;
        }
        public virtual void EatGrass()
        {
            Console.WriteLine($"{this.GetType().Name} кушает траву.");
            Weight += 10;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} с весом {Weight}. Живое: {IsAlive}.";
        }
    }
}
