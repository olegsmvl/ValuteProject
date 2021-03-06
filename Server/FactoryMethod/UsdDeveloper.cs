using System;
using System.Collections.Generic;
using System.Text;

namespace Server.FactoryMethod
{
    public class UsdDeveloper : Developer
    {
        public UsdDeveloper(string n) : base(n)
        {

        }
        public override Exchanger Create()
        {
            return new UsdExchanger();
        }
    }
}
