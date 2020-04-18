using System;
using Base;

namespace Decorator
{
    /// <summary>
    /// Decorator pattern is used when you want to attach state or behaviour to existing
    /// classed without changing the hierarchy and structure.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle myCar = new Saloon(new StandardEngine(1300));
            myCar.Paint(VehicleColour.Blue);

            myCar = new AirConditionedVehicle(myCar);

            myCar = new LeatherSeatVehicle(myCar);

            myCar = new SatNavVehicle(myCar);

            Console.WriteLine(myCar);

            Console.Read();
        }
    }
}
