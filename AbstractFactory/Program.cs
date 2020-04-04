using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string whatToMake = "car"; //van

            AbstractVehicleFactory factory = null;

            if(whatToMake=="car")
            {
                factory = new CarFactory();
            }
            else
            {
                factory = new VanFactory();
            }

            IBody vehicleBody = factory.CreateBody();
            IGlassaware vehicleGlassWare = factory.CreateGlassWare();
            IChassis vehicleChassis = factory.CreateChassis();

            Console.WriteLine(vehicleBody.BodyPart);
            Console.WriteLine(vehicleGlassWare.GlasswareParts);
            Console.WriteLine(vehicleChassis.ChassisPart);
        }
    }
}
