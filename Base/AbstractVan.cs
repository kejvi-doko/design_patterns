using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine)
            : this(engine, VehicleColour.Unpainted)
        {
        }
        public AbstractVan(IEngine engine, VehicleColour colour)
            : base(engine, colour)
        {
        }
    }
}
