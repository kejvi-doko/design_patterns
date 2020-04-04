using Base;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory carFactory = new CarFactory();
            IVehicle car = carFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColour.Black);
            Console.WriteLine(car);

            VehicleFactory vanFactory = new VanFactory();
            IVehicle van = vanFactory.Build(VehicleFactory.DrivingStyle.Powerful, VehicleColour.White);
            Console.WriteLine(van);
            Console.Read();
        }
    }
}
