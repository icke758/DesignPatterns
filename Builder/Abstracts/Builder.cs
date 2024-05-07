using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Product;

namespace Builder.Abstracts
{
    public class Builder
    {
        public abstract class VehicleBuilder
        {
            protected Vehicle? vehicle;

            public Vehicle? Vehicle
            {
                get { return vehicle; }
            }

            public abstract void BuildFrame();
            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();

        }

    }
}
