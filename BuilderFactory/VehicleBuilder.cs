using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() {}
        public virtual void BuildBoot() { }
        public virtual void BuildChasis() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }
        public abstract IVehicle Vehicle { get; }
    }
}
