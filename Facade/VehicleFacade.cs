using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Facade
{
    /// <summary>
    /// Provide a unified interface to a set of interfaces in a subsystem.
    /// Facade defines a higher-level interface that makes the subsystem easier to use.
    /// </summary>
    public class VehicleFacade
    {
        public virtual void PrepareForSale(IVehicle vehicle)
        {
            Registration reg = new Registration(vehicle);
            reg.AllocateVehicleNumber();
            reg.AllocateLicensePlate();
            Documentation.PrintBrochure(vehicle);
            vehicle.CleanInterior();
            vehicle.CleanExterior();
            vehicle.PolishWindows();
            vehicle.TakeForTestDrive();
        }
    }
}
