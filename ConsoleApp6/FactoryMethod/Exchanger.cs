using ModelCourse;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.FactoryMethod
{
    public abstract class Exchanger
    {
        public abstract string ShowExchangeRate(Course rates);
    }
}
