using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Decorator
{
    public class LeatherSeatVehicle: AbstractVehicleOption
    {
        public LeatherSeatVehicle(IVehicle vehicle) : base(vehicle)
        {
        }

        public override int Price => decoratedVehicle.Price + 1200;
    }
}
