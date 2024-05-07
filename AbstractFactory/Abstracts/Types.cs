namespace AbstractFactory.Abstracts
{
    public class Types
    {
        public abstract class Herbivore { }

        public abstract class Carnivore
        {
            public abstract void Eat(Herbivore herbivore);
        }
    }
}
