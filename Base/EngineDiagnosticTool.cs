using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Base
{
    public class EngineDiagnosticTool:IDiagnosticTool
    {
        public void RunDiagnostic(object obj)
        {
            Console.WriteLine($"Staring diagnostic tool for {obj}");

            Thread.Sleep(5000);

            Console.WriteLine("Engine diagnostic completed");
        }
    }
}
