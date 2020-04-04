using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class VanBody:IBody
    {
        public virtual string BodyPart => "Van body parts";
    }
}
