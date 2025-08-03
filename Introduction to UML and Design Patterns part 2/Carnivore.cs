using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_UML_and_Design_Patterns_part_2
{
    public abstract class Carnivore
    {
        public int Power { get; protected set; }
        public Carnivore(int power = 20)
        {
            Power = power;
        }
        public virtual void Eat(Herbivore herbivore)
        {
            if (!herbivore.IsAlive)
            {
                return;
            }
            if (Power < herbivore.Weight)
            {
                Power -= 10;
                Console.WriteLine($"{this.GetType().Name} слишком слаб, что бы справиться {herbivore.GetType().Name}. Сила уменьшена до {Power}.");
                return;
            }
            Power += 10;
            herbivore.IsAlive = false;
            Console.WriteLine($"{this.GetType().Name} съел {herbivore.GetType().Name}. Сила увеличена до {Power}.");
        }
        public override string ToString()
        {
            return $"{this.GetType().Name} с силой {Power}.";
        }

    }
}
