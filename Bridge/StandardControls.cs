using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Bridge
{
    public class StandardControls:AbstractDriverControllers
    {
        public StandardControls(IEngine engine) : base(engine)
        {
        }
    }
}
