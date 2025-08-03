using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Africa.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Africa
{
    public class Africa : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

    }
}
