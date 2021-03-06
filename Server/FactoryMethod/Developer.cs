using System;
using System.Collections.Generic;
using System.Text;

namespace Server.FactoryMethod
{
    public abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string n)
        {
            Name = n;
        }
        public abstract Exchanger Create();
    }
}
