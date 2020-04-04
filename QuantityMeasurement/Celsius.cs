using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Celsius
    {
        private readonly double celcius;

        public Celsius()
        {
        }

        public Celsius(double celcius)
        {
            this.celcius = celcius;
        }

        public double CheckForEqualValue()
        {
            return this.celcius;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
