using Model;
using Repository.RepositoryInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager
{
    public class MeasurementManager : IMeasurementManager
    {

        private IMeasurementRepository measurementRepository;

        public MeasurementManager(IMeasurementRepository measurementRepository)
        {
            this.measurementRepository = measurementRepository;
        }
       

        public decimal CentimetertoMeter(MeasuringUnits value)
        {
            return this.measurementRepository.CentimetertoMeter(value);
        }

        public decimal FeettoInch(MeasuringUnits value)
        {
            return this.measurementRepository.FeettoInch(value);
        }

        public decimal GramsToKilograms(MeasuringUnits value)
        {
            return this.measurementRepository.GramsToKilograms(value);
        }

        public decimal InchToFeet(MeasuringUnits value)
        {
            return this.measurementRepository.InchToFeet(value);
        }

        public decimal KilogramsToGrams(MeasuringUnits value)
        {
            return this.measurementRepository.KilogramsToGrams(value);
        }

        public decimal MetertoCentimeter(MeasuringUnits value)
        {
            return this.measurementRepository.MetertoCentimeter(value);
        }
    }
}
