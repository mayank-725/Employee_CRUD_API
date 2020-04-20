﻿using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.RepositoryInterface
{
    public interface IMeasurementRepository
    {
        decimal FeettoInch(MeasuringUnits value);

        decimal InchToFeet(MeasuringUnits value);

        decimal MetertoCentimeter(MeasuringUnits value);

        decimal CentimetertoMeter(MeasuringUnits value);

        decimal KilogramsToGrams(MeasuringUnits value);

        decimal GramsToKilograms(MeasuringUnits value);
    }
}
