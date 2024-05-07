using static AbstractFactory.Abstracts.Factory;
using static AbstractFactory.Abstracts.Types;
using static AbstractFactory.Concretes.Types;

namespace AbstractFactory.Concretes.America
{
    public class AmericaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
