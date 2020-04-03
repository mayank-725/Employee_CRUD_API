using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        private readonly double inch;

        public Inch(double inch)
        {
            this.inch = inch;
        }
        public double CheckValue()
        {
            return this.inch;
        }
    }
}
