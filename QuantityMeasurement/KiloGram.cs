using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class KiloGram
    {
        private readonly double kiloGram;

        public KiloGram()
        {
        }

        public KiloGram(double kiloGram)
        {
            this.kiloGram = kiloGram;
        }

        public double CheckForEqualValue()
        {
            return this.kiloGram;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
