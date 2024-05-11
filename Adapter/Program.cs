using Adapter.Adapters;
using Adapter.Targets;

internal class Program
{
    private static void Main(string[] args)
    {
        Compound unkown = new();
        unkown.Display();

        Compound water = new RichCompound("Water");
        water.Display();

        Compound benzene = new RichCompound("Benzene");
        benzene.Display();

        Compound ethanol = new RichCompound("Ethanol");
        ethanol.Display();

        Console.ReadKey();
    }
}