using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Africa;
using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Eurasia;
using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.Eurasia.Animals;
using Introduction_to_UML_and_Design_Patterns_part_2.ContinentFactory.NorthAmerica.Animal;

namespace Introduction_to_UML_and_Design_Patterns_part_2
{            /*Abstract Factory
Спроектируйте приложение, используя паттерн «абстрактная
фабрика», который будет симулировать животную жизнь на разных
континентах земного шара.
В программе весь животный мир будет разделен на части:
травоядные и хищники (абстрактные продукты).
Добавьте к абстрактному продукту «хищник» метод «кушать»,
который будет принимать в себя объект «травоядного» (абстрактный
продукт).

Наследники класса «Континент» (абстрактная фабрика) будут
порождать конкретные объекты с именами и функциями, присущими их
флоре и фауне.
Всеми процессами в программе будет управлять класс «мир
животных» (клиент).
Конкретные объекты:
 Континент (Continent) - абстрактная фабрика;
o Африка (Africa) - конкретная фабрика;
o Северная Америка (North America) - конкретная фабрика;
 Травоядное животное (Herbivore) - абстрактный продукт;
o Антилопа Гну (Wildebeest) - конкретный продукт;
 Вес (Weight) - свойство травоядного животного;
 Кушать траву (Eat grass) - метод конкретного продукта
(добавляют к весу +10);
 Жизнь (Life) - свойство животного (характеризует живое
ли существо);
o Бизон (Bison) - конкретный продукт;
 Вес (Weight) - свойство травоядного животного;
 Кушать траву (Eat grass) - метод конкретного продукта
(добавляют к весу +10);
 Жизнь (Life) свойство животного (характеризует живое ли
существо);
 Плотоядное животное (Carnivore) - абстрактный продукт;
o Лев (Lion) - конкретный продукт;
 Сила (Power) - свойство плотоядного животного;
 Кушать травоядное животное (Eat) - метод конкретного
продукта, при выполнении которого проверяется,
является ли сила плотоядного животного больше, чем вес
травоядного, которого он съедает. Если является, то
хищник получает +10 к силе, иначе, если сила меньше,
чем вес травоядного животного, то сила плотоядного
уменьшаются на -10.
o Волк (Wolf) - конкретный продукт;
 Сила (Power) свойство плотоядного животного;
 Кушать травоядное животное (Eat) - метод конкретного
продукта, при выполнении которого проверяется,
является ли сила плотоядного животного больше, чем вес
травоядного, которого он съедает. Если является, то
хищник получает +10 к силе, иначе, если сила меньше,
чем вес травоядного животного, то сила плотоядного
уменьшаются на -10.
 Мир животных (Animal World) – клиент;
o Питание травоядных (Meals herbivores) - метод клиента,
который инициирует всех травоядных приступить к кормежке;
o Питание плотоядных (Nutrition carnivores) - метод клиента,
который заставит всех плотоядных охотится на травоядных.
Постройте данную программу на паттерне «абстрактная фабрика».
Дополните данное приложение, добавив новый континент «Евразия»,
в котором травоядным будет «Лось» (Elk), а плотоядным - «Тигр» (Tiger).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // AFRICA
            var africa = new Africa();
            int hCountAfrica = rnd.Next(1 , 6);   
            int cCountAfrica = rnd.Next(1 , 4);   

            List<Herbivore> africaHerbivores = new();
            for (int i = 0; i < hCountAfrica; i++)
                africaHerbivores.Add(africa.CreateHerbivore());

            List<Carnivore> africaCarnivores = new();
            for (int i = 0; i < cCountAfrica; i++)
                africaCarnivores.Add(africa.CreateCarnivore());

            Console.WriteLine($"--- AFRICA ({hCountAfrica} herbivores, {cCountAfrica} carnivores) ---");
            var africaWorld = new AnimalWorld(africaHerbivores , africaCarnivores);
            africaWorld.MealsHerbivores();
            africaWorld.NutritionCarnivores();
            // AFRICA
            var northAmerica = new NorthAmerica();
            int hCountAmerica = rnd.Next(1 , 6);   
            int cCountAmerica = rnd.Next(1 , 4);   

            List<Herbivore> AmericaHerbivores = new();
            for (int i = 0; i < hCountAmerica; i++)
                AmericaHerbivores.Add(africa.CreateHerbivore());

            List<Carnivore> AmericaCarnivores = new();
            for (int i = 0; i < cCountAmerica; i++)
                AmericaCarnivores.Add(northAmerica.CreateCarnivore());

            Console.WriteLine($"\n--- America ({hCountAmerica} herbivores, {cCountAmerica} carnivores) ---");
            var AmericaWorld = new AnimalWorld(AmericaHerbivores , AmericaCarnivores);
            AmericaWorld.MealsHerbivores();
            AmericaWorld.NutritionCarnivores();


            // EURASIA
            var eurasia = new Eurasia();
            int hCountEu = rnd.Next(1 , 6);
            int cCountEu = rnd.Next(1 , 4);

            List<Herbivore> eurHerbivores = new();
            for (int i = 0; i < hCountEu; i++)
                eurHerbivores.Add(eurasia.CreateHerbivore());

            List<Carnivore> eurCarnivores = new();
            for (int i = 0; i < cCountEu; i++)
                eurCarnivores.Add(eurasia.CreateCarnivore());

            Console.WriteLine($"\n--- EURASIA ({hCountEu} herbivores, {cCountEu} carnivores) ---");
            var eurasiaWorld = new AnimalWorld(eurHerbivores , eurCarnivores);
            eurasiaWorld.MealsHerbivores();
            eurasiaWorld.NutritionCarnivores();
        }
    }
}
