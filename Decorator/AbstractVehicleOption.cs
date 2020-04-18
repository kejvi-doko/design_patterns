using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    public abstract class AbstractVehicleOption:AbstractVehicle
    {
        protected internal IVehicle decoratedVehicle;

        public AbstractVehicleOption(IVehicle vehicle):base(vehicle.Engine)
        {
            decoratedVehicle = vehicle;
        }
    }
}
