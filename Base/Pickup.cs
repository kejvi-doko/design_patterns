using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }
        public Pickup(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }

        public override int Price => 9000;
    }
}
