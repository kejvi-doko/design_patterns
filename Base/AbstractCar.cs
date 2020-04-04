using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine)
         : this(engine, VehicleColour.Unpainted)
        {
        }

        public AbstractCar(IEngine engine, VehicleColour colour)
         : base(engine, colour) { }

    }
}
