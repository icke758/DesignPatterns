using static AbstractFactory.Abstracts.Types;

namespace AbstractFactory.Concretes
{
    public class Types
    {
        public class Bison : Herbivore { }

        public class Wildbeast : Herbivore { }


        public class Lion : Carnivore
        {
            public override void Eat(Herbivore herbivore)
            {
                Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
            }
        }

        public class Wolf : Carnivore
        {
            public override void Eat(Herbivore herbivore)
            {
                Console.WriteLine($"{GetType().Name} eats {herbivore.GetType().Name}");
            }
        }
    }
}
