using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public class CarDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildChasis();
            builder.BuildBody();
            builder.BuildPassengerArea();
            builder.BuildBoot();
            builder.BuildWindows();

            return builder.Vehicle;
        }
    }
}
