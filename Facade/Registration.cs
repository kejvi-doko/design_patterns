using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Facade
{
    public class Registration
    {
        private IVehicle vehicle;

        public Registration(IVehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        public void AllocateLicensePlate()
        {
            Console.WriteLine("Allocating License Plate...");
        }

        public void AllocateVehicleNumber()
        {
            Console.WriteLine("Allocating Vehicle Number...");
        }
    }
}
