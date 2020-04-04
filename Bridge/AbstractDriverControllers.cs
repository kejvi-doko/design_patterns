using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Base;

namespace Bridge
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

        public virtual void Brake()
        {
            engine.DecreasePower();
        }

    }
}
