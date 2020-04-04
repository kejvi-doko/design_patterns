using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderFactory
{
    public class VanBuilder : VehicleBuilder
    {
        public override IVehicle Vehicle => vanInProgress;
        private AbstractVan vanInProgress;

        public override void BuildBody()
        {
            Console.WriteLine("Building Van Body");
        }

        public override void BuildChasis()
        {
            Console.WriteLine("Building Van Chasis");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("Building Reinforced Storage Area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("Building Van Window");
        }


    }
}
