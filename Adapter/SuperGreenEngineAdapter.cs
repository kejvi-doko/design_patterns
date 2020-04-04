using Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class SuperGreenEngineAdapter : AbstractEngine
    {
        public SuperGreenEngineAdapter(SuperGreenEngine engine):base(engine.Size,false)
        {

        }
    }
}
