namespace Prototype.Prototypes;

public class Color : ColorPrototype
{
    int red;
    int green;
    int blue;

    public Color(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    public override ColorPrototype? Clone()
    {
        Console.WriteLine($"Cloning color RGB {red}, {green}, {blue}");

        return MemberwiseClone() as ColorPrototype;
    }
}
