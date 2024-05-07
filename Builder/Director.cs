using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Builder.Abstracts.Builder;

namespace Builder
{
    public class Director
    {
        public class Shop
        {
            public void Construct(VehicleBuilder vehicleBuilder)
            {
                vehicleBuilder.BuildFrame();
                vehicleBuilder.BuildEngine();
                vehicleBuilder.BuildWheels();
                vehicleBuilder.BuildDoors();
            }
        }

    }
}
