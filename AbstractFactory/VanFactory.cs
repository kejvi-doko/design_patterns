using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class VanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override IGlassaware CreateGlassWare()
        {
            return new VanGlassware();
        }
    }
}
