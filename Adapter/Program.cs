using Base;
using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperGreenEngine greenEngine = new SuperGreenEngine(1200);
            AbstractEngine engine1 = new StandardEngine(1500);
            AbstractEngine engine2 = new TurboEngine(1800);

            List<AbstractEngine> engineList = new List<AbstractEngine>();
            engineList.Add(new SuperGreenEngineAdapter(greenEngine));
            engineList.Add(engine1);
            engineList.Add(engine2);

            foreach(var eng in engineList)
            {
                Console.WriteLine(eng);
            }

            Console.Read();
        }
    }
}
