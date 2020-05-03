﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace QuantityMeasurementBackendProject
{

    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementQuantityController : ControllerBase
    {
       public  RedisCaching redis = new RedisCaching();

        public IMeasurementManager measurementManager;

        public MessagingQueue messagingQueue=new MessagingQueue();

        public MeasurementQuantityController(IMeasurementManager measurementManager)
        {
            this.measurementManager = measurementManager;
        }

        [Route("RedisCache")]
        [HttpGet]
        public string redisCacheValues(string key)
        {
            return redis.RedisConnection(key);
        }

        // GET api/values
        [Route("FeettoInch")]
        [HttpPost]
        public IActionResult FeettoInch(MeasuringUnits value)
        {
            var result = this.measurementManager.FeettoInch(value);

            if (result >= 0)
            {
              messagingQueue.SendMessage("feet", result);

                return this.Ok(result);
            }
            return this.BadRequest();
        }


        [Route("InchToFeet")]
        [HttpPost]
        public IActionResult InchToFeet(MeasuringUnits value)
        {
            var result = this.measurementManager.InchToFeet(value);

            if (result >= 0)
            {
                messagingQueue.SendMessage("Inch", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("MetertoCentimeter")]
        [HttpPost]
        public IActionResult MetertoCentimeter(MeasuringUnits value)
        {
            var result = this.measurementManager.MetertoCentimeter(value);

            if (result >= 0)
            {
                messagingQueue.SendMessage("Meter", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("CentimetertoMeter")]
        [HttpPost]
        public IActionResult CentimetertoMeter(MeasuringUnits value)
        {
            var result = this.measurementManager.CentimetertoMeter(value);

            if (result >= 0)
            {
                messagingQueue.SendMessage("Centimeter", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("KilogramToGram")]
        [HttpPost]
        public IActionResult KilogramsToGrams(MeasuringUnits value)
        {
            
            var result = this.measurementManager.KilogramsToGrams(value);

            if (result >= 0)
            {
                messagingQueue.SendMessage("Kilogram", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }

        [Route("GramToKilogram")]
        [HttpPost]
        public IActionResult GramsToKilograms(MeasuringUnits value)
        {
           
            var result = this.measurementManager.GramsToKilograms(value);

            if (result >= 0)
            {
                messagingQueue.SendMessage("gram", result);
                return this.Ok(result);
            }
            return this.BadRequest();
        }
    }
}