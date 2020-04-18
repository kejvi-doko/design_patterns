using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Decorator
{
    public class AirConditionedVehicle: AbstractVehicleOption
    {
        public AirConditionedVehicle(IVehicle vehicle) : base(vehicle)
        {
            temperature = 16;
        }

        public override int Price => decoratedVehicle.Price + 600;
        private int temperature;
        public virtual int Temperature
        {
            set
            {
                if (value <= 16)
                    temperature = 16;
                else if (value >= 26)
                    temperature = 26;
                else
                    temperature = value;
            }
        }
    }
}
