using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        public int feet;

        public Feet(int feet)
        {
            this.feet = feet;
        }

       

        public override bool Equals(object obj)
        {
            if (this.GetType().Equals(obj.GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EqualsCheck(Feet feet)
        {
            if (this.feet.Equals(feet.feet))
                return true;
            else
                return false;
        }
    }
}
