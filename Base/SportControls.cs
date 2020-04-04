using System;
using System.Collections.Generic;
using System.Text;

namespace Base
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
