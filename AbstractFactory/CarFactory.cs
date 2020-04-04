using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassaware CreateGlassWare()
        {
            return new CarGlassware();
        }
    }
}
