using System;
using Base;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            IEngine engine = new StandardEngine(1300);

            StandardControls controls1 = new StandardControls(engine);

            controls1.IgniteOn();
            controls1.Accelerate();
            controls1.Brake();
            controls1.IgniteOff();

            SportControls controls2 = new SportControls(engine);
            controls2.IgniteOn();
            controls2.Accelerate();
            controls2.AccelerateHard();
            controls2.Brake();
            controls2.IgniteOff();


            Console.Read();



        }
    }
}
