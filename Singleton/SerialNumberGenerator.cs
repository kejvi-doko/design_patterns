using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SerialNumberGenerator
    {
        private static volatile SerialNumberGenerator instance;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        private int count;

        private SerialNumberGenerator()
        {
            count = 0;
        }

        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }

    }
}
