using System;
using System.Collections.Generic;
using System.Text;
using ModelCourse;

namespace Server.FactoryMethod
{
    public class EurExchanger : Exchanger
    {
        public EurExchanger()
        {
        }

        public override string ShowExchangeRate(Course rates)
        {
            return $"{rates.Date} {rates.Timestamp} {rates.Valute.EUR.Name} {rates.Valute.EUR.Value}" ;
        }
    }
}
