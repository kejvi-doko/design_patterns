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
        int Price { get; }
    }
}
