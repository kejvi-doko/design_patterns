using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public interface IVehicle:ICloneable
    {
        IEngine Engine { get; }
        VehicleColour Colour { get; }
        void Paint(VehicleColour colour);
        void CleanInterior();
        void CleanExterior();
        void PolishWindows();
        void TakeForTestDrive();
        int Price { get; }
    }
}
