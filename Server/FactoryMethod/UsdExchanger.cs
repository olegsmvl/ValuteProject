using System;
using System.Collections.Generic;
using System.Text;
using ModelCourse;

namespace Server.FactoryMethod
{
    public class UsdExchanger : Exchanger
    {
        public UsdExchanger()
        {
        }

        public override string ShowExchangeRate(Course rates)
        {
            return $"{rates.Date} {rates.Timestamp} {rates.Valute.USD.Name} {rates.Valute.USD.Value}" ;
        }
    }
}
