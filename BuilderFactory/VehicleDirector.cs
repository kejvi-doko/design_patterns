using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public abstract class VehicleDirector
    {
        public abstract IVehicle Build(VehicleBuilder builder);
    }
}
