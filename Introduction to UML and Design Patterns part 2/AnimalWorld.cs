using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory;
namespace Introduction_to_UML_and_Design_Patterns_part_2
{
    public class AnimalWorld
    {
        public List<Herbivore> Animals { get; set; } = new List<Herbivore>();
        public List<Carnivore> Predators { get; set; } = new List<Carnivore>();

        public AnimalWorld(List<Herbivore> herbivores , List<Carnivore> carnivores)
        {
            Animals = herbivores;
            Predators = carnivores;
        }
        public void MealsHerbivores()
        {
            foreach (var herbivore in Animals)
            {
                herbivore.EatGrass();
            }
        }
        public void NutritionCarnivores()
        {
            foreach (var predator in Predators)
            {
                if (Animals.Count == 0)
                {
                    Console.WriteLine("No herbivores available for the predator to eat.");
                    return;
                }
                foreach (var herbivore in Animals)
                {
                   
                    predator.Eat(herbivore);
                }
            }
        }

    }
}


