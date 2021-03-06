using System;
using System.Collections.Generic;
using System.Text;

namespace Server.FactoryMethod
{
    public class EurDeveloper : Developer
    {
        public EurDeveloper(string n) : base(n)
        {

        }
        public override Exchanger Create()
        {
            return new EurExchanger();
        }
    }
}
