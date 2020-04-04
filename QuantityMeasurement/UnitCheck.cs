﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class UnitCheck
    {
        public string type;

       
        public double length;

       
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

        
        public double EqualsCheck()
        {
            return this.length;
        }

        public double ConvertFeetToInch()
        {
            return this.length * 12; ;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || Object.ReferenceEquals(this, obj) || this.GetType().Equals(obj.GetType()))
                return true;

            return false;
        }
    }
}
