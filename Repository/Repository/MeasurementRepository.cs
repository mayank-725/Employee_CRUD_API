using Model;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MeasurementRepository : IMeasurementRepository
    {
        public decimal CentimetertoMeter(MeasuringUnits value)
        {
            return value.Centimeter / 100;
        }

        public decimal FeettoInch(MeasuringUnits value)
        {
            return value.Feet * 12;
        }

        public decimal GramsToKilograms(MeasuringUnits value)
        {
            return value.Gram / 1000;
        }

        public decimal InchToFeet(MeasuringUnits value)
        {
            return value.Inch / 12;
        }

        public decimal KilogramsToGrams(MeasuringUnits value)
        {
            return value.KiloGram * 1000;
        }

        public decimal MetertoCentimeter(MeasuringUnits value)
        {
            return value.Meter * 100;
        }
    }
}
