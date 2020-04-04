using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class Coupe: AbstractCar
    {
        public Coupe(IEngine engine) : this(engine, VehicleColour.Unpainted)
        {
        }

        public Coupe(IEngine engine, VehicleColour colour)
         : base(engine, colour)
        {
        }
    }
}
