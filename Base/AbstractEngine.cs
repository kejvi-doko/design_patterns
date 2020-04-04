using System;
using System.Collections.Generic;
using System.Text;

namespace Base
{
    public abstract class AbstractEngine : IEngine
    {
        public virtual int Size => size;

        public virtual bool Turbo => turbo;
        public void Start()
        {
            this.running = true;
        }

        public void Stop()
        {
            this.running = false;
            this.power = 0;
        }

        public void IncreasePower()
        {
            if (running && power < 10)
            {
                this.power++;
            }
        }

        public void DecreasePower()
        {
            if (running && power > 10)
            {
                this.power--;
            }
        }

        private int size;
        private bool turbo;
        private bool running;
        private int power;
        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
            this.running = false;
            this.power = 0;
        }

        public override string ToString()
        {
            return this.GetType().Name + "(" + size + ")";
        }

    }
}
