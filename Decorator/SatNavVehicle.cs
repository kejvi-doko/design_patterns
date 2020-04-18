using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Decorator
{
    public class SatNavVehicle:AbstractVehicleOption
    {
        public SatNavVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 1500;
    }
}
