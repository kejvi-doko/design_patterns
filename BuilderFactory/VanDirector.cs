using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChasis();
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
