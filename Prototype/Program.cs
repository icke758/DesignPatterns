using Prototype.Clients;
using Prototype.Prototypes;

internal class Program
{
    public static void Main()
    {
        ColorManager colorManager = new();

        colorManager["red"] = new Color(255, 0, 0);
        colorManager["green"] = new Color(0, 255, 0);
        colorManager["blue"] = new Color(0, 0, 255);

        colorManager["angry"] = new Color(255, 54, 0);
        colorManager["peace"] = new Color(128, 211, 128);
        colorManager["flame"] = new Color(211, 34, 20);

        _ = colorManager["red"].Clone() as Color;
        _ = colorManager["peace"].Clone() as Color;
        _ = colorManager["flame"].Clone() as Color;

        Console.ReadKey();
    }
}