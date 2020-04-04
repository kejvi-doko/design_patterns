using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Base
{
    public class AbstractDriverControllers
    {
        private IEngine engine;

        public AbstractDriverControllers(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IgniteOn()
        {
            engine.Start();
        }

        public virtual void IgniteOff()
        {
            engine.Stop();
        }

        public virtual void Accelerate()
        {
            engine.IncreasePower();
        }

        public virtual void Stop()
        {
            engine.DecreasePower();
        }

    }
}
