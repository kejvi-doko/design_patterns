using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarBody : IBody
    {
        public virtual string BodyPart => "Car body parts";
    }
}
