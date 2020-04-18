using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Decorator
{
    public class AlloyWheeledVehicle: AbstractVehicleOption
    {
        public AlloyWheeledVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 250;
    }
}
