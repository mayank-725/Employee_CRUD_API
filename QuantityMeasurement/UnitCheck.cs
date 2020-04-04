using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitCheck
    {
        public string type;

       
        public double length;

        public double weight;

       
        public UnitCheck()
        {

        }

      
        public UnitCheck(string type, double length)
        {
            this.type = type;
            this.length = length;
        }

      
        public UnitCheck(string type)
        {
            this.type = type;
        }
        public double CheckForEqualValue()
        {
            return this.weight;
        }

        public double EqualsCheck()
        {
            return this.length;
        }

        public double ConvertFeetToInch()
        {
            return this.length * 12; ;
        }

        public double ConvertInchToFeet()
        {
            return this.length / 12;
        }

        public double ConverFeetintoYard()
        {
            return this.length / 3;
        }

        public double InchToYard()
        {
            return this.length / 36;
        }

        public double YardToInch()
        {
            return this.length * 36;
        }

        public double YardToFeet()
        {
            return this.length * 3;
        }


        public double ConvertGramToKiloGram()
        {
            return this.weight / 1000;
        }

        public double ConvertKiloGramToGram()
        {
            return this.weight * 1000;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
