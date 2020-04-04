using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class VehicleFactory
    {
        public enum DrivingStyle
        {
            Economical, Midrange, Powerful
        }

        public static IVehicle Make(Category category, DrivingStyle style,VehicleColour color)
        {
            VehicleFactory factory = null;

            if(category==Category.Car)
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            return factory.Build(style, color);
        }

        public virtual IVehicle Build(DrivingStyle style, VehicleColour colour)
        {
            IVehicle v = SelectVehicle(style);
            v.Paint(colour);
            return v;

        }

        protected internal abstract IVehicle SelectVehicle(DrivingStyle style);
    }
}
