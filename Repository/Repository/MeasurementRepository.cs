using Model;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class MeasurementRepository : IMeasurementRepository
    {
        public RedisCaching redis = new RedisCaching();

        public decimal CentimetertoMeter(MeasuringUnits value)
        {
            decimal result = value.Centimeter / 100;
            redis.RedisConnection($"Centimeter", result.ToString());
            return value.Centimeter / 100;
        }

        public decimal FeettoInch(MeasuringUnits value)
        {
            decimal result= value.Feet * 12;
            redis.RedisConnection($"Feet", result.ToString());
            return result;
        }

        public decimal GramsToKilograms(MeasuringUnits value)
        {
            decimal result = value.Gram / 1000;
            redis.RedisConnection($"Grams", result.ToString());
            return result;
        }

        public decimal InchToFeet(MeasuringUnits value)
        {
            decimal result = value.Inch / 12;
            redis.RedisConnection($"Inch", result.ToString());
            return result;
        }

        public decimal KilogramsToGrams(MeasuringUnits value)
        {
            decimal result = value.KiloGram * 1000;
            redis.RedisConnection($"Kilograms", result.ToString());
            return result;
        }

        public decimal MetertoCentimeter(MeasuringUnits value)
        {
            decimal result = value.Meter * 100;
            redis.RedisConnection($"Meter", result.ToString());
            return result;
        }
    }
}
