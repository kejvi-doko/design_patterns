using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class Sport: AbstractCar
    {
        public Sport(IEngine engine)
         : this(engine, VehicleColour.Unpainted)
        {
        }

        public Sport(IEngine engine, VehicleColour colour):base(engine,colour) { }

        public override int Price => 8000;
    }
}
