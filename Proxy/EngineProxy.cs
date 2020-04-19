using Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Proxy
{
    public class EngineProxy:IEngine
    {
        private IEngine engine;
        public virtual int Size => engine.Size;
        public virtual bool Turbo => engine.Turbo;

        public EngineProxy(int size, bool turbo)
        {
            if (turbo)
                engine = new TurboEngine(size);
            else
                engine = new StandardEngine(size);
        }

        public void Start()
        {
            engine.Start();
        }

        public void Stop()
        {
            engine.Stop();
        }

        public void IncreasePower()
        {
            engine.IncreasePower();
        }

        public void DecreasePower()
        {
            engine.DecreasePower();
        }

        public void Diagnose(IDiagnosticTool tool)
        {
            Console.WriteLine("(Running tool as thread)");
            Thread t = new Thread(() => RunDiagnosticTool(tool));
            t.Start();
            Console.WriteLine("EngineProxy diagnose() method finished");
        }
        public virtual void RunDiagnosticTool(IDiagnosticTool tool)
        {
            tool.RunDiagnostic(this);
        }

        
    }
}
