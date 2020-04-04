using Base;
using System;

namespace BuilderFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();

            IVehicle v = director.Build(builder);

            Console.WriteLine(v);
            Console.Read();
        }
    }
}
