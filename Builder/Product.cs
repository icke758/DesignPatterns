namespace Builder
{
    public class Product
    {
        public class Vehicle
        {
            private readonly string? _veichleType;
            private readonly Dictionary<string, string> _parts =
                new();

            public Vehicle(string? veichleType)
            {
                _veichleType = veichleType;
            }

            public string this[string key]
            {
                get { return _parts[key]; }
                set { _parts[key] = value; }
            }

            public void Show()
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine(_veichleType);
                Console.WriteLine($"Frame: {_parts["frame"]}");
                Console.WriteLine($"Engine: {_parts["engine"]}");
                Console.WriteLine($"Wheels: {_parts["wheels"]}");
                Console.WriteLine($"Doors: {_parts["doors"]}");
            }
        }
    }
}
