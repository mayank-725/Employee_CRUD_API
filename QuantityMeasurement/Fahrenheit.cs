using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Fahrenheit
    {
        private readonly double farenheit;

        public Fahrenheit()
        {
        }

        public Fahrenheit(double farenheit)
        {
            this.farenheit = farenheit;
        }

        public double CheckForEqualValue()
        {
            return this.farenheit;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
