using AbstractFactory.Concretes.Africa;
using AbstractFactory.Concretes.America;
using static AbstractFactory.Abstracts.Factory;
using static AbstractFactory.Abstracts.Types;
using static AbstractFactory.Client;
using static AbstractFactory.Concretes.Africa.AfricaFactory;
using static AbstractFactory.Concretes.America.AmericaFactory;


internal class Program
{
    class MainApp
    {
        private static void Main()
        {
            //Create Africa
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new(africa);
            world.RunFoodChain();

            //Create America
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadKey();

        }
    }
}