using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Decorator
{
    public class MetallicPaintedVehicle: AbstractVehicleOption
    {
        public MetallicPaintedVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 750;
    }
}
