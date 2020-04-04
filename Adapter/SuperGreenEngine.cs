using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SuperGreenEngine
    {
        private int size;

        public int Size => size;

        public SuperGreenEngine(int size)
        {
            this.size = size;
        }
    }
}
