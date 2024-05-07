using static AbstractFactory.Abstracts.Factory;
using static AbstractFactory.Abstracts.Types;

namespace AbstractFactory
{
    public class Client
    {
        public class AnimalWorld
        {
            private readonly Herbivore _herbivore;
            private readonly Carnivore _carnivore;

            public AnimalWorld(ContinentFactory factory)
            {
                _carnivore = factory.CreateCarnivore();
                _herbivore = factory.CreateHerbivore();
            }

            public void RunFoodChain()
            {
                _carnivore.Eat(_herbivore);
            }
        }
    }
}
