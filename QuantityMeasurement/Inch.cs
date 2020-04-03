using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        private readonly double inch;

        public Inch()
        {
        }

        public Inch(double inch)
        {
            this.inch = inch;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }

        public double CheckValue()
        {
            return this.inch;
        }
    }
}
