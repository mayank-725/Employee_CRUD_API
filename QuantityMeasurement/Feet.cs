using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        public int feet;

        private object p;

        public Feet()
        {
        }


        public Feet(int feet)
        {
            this.feet = feet;
        }

        public Feet(object p)
        {

            this.p = p;
        }


        public override bool Equals(object obj)
        {
            if((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

               return false;
        }
     
        public int  EqualsCheck(Feet feet)
        {
            return this.feet;
        }
    }
}
