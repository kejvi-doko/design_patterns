using System;
using System.Collections.Generic;
using System.Text;
using Base;

namespace Bridge
{
    public class SportControls:AbstractDriverControllers
    {
        public SportControls(IEngine engine) : base(engine)
        {
        }

        public virtual void AccelerateHard()
        {
            Accelerate();
            Accelerate();
        }
    }
}
