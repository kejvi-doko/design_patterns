using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public class VanFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle(DrivingStyle style)
        {
            if (style == DrivingStyle.Economical || style == DrivingStyle.Midrange)
                return new Pickup(new StandardEngine(2200));
            else
                return new BoxVan(new TurboEngine(2500));
        }
    }
}
