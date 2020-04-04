using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarChassis : IChassis
    {
        public virtual string ChassisPart => "Car Chasis Parts";
    }
}
