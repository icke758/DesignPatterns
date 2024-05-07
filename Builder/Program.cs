using Builder.Concretes.Builders;
using static Builder.Abstracts.Builder;
using static Builder.Director;

internal class Program
{
    private static void Main()
    {
        VehicleBuilder builder;

        Shop shop = new();

        builder = new ScooterBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();

        builder = new CarBuilder();
        shop.Construct(builder);
        builder.Vehicle.Show();
    }
}