using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Eurasia.Animals
{
    public class Eurasia : Continent 
    {
        public override Herbivore CreateHerbivore() => new Elk();
        public override Carnivore CreateCarnivore() => new Tiger();
    }
}
