using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public class CarBuilder : VehicleBuilder
    {
        public override IVehicle Vehicle => carInProgress;
        private AbstractCar carInProgress;
        public CarBuilder(AbstractCar car)
        {
            carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("Building Car Body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("Building Car Boot");
        }

        public override void BuildChasis()
        {
            Console.WriteLine("Building Car Chasis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("Building Car Passenger Area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building Car Windows");
        }

    }
}
