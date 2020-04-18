using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public class AbstractVehicle: IVehicle 
    {
        private IEngine engine;
        private VehicleColour colour;
        public AbstractVehicle(IEngine engine)
            : this(engine, VehicleColour.Unpainted) { }

        public AbstractVehicle(IEngine engine, VehicleColour colour)
        {
            this.engine = engine;
            this.colour = colour;
        }

        public IEngine Engine => engine;

        public VehicleColour Colour => colour;

        public void Paint(VehicleColour colour)
        {
            this.colour = colour;
        }

        public virtual int Price { get; }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + colour +", " + Price+")";
        }
        public virtual Object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
