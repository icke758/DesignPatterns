using static AbstractFactory.Abstracts.Types;

namespace AbstractFactory.Abstracts
{
    public class Factory
    {
        public abstract class ContinentFactory
        {
            public abstract Herbivore CreateHerbivore();
            public abstract Carnivore CreateCarnivore();
        }
    }
}
