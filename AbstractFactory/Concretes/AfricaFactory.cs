using static AbstractFactory.Abstracts.Factory;
using static AbstractFactory.Abstracts.Types;
using static AbstractFactory.Concretes.Types;

namespace AbstractFactory.Concretes.Africa
{
    public class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeast();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
