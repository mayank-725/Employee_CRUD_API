using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class MeasuringUnits
    {
        /// <summary>
        /// The centimeter
        /// </summary>
        private decimal centimeter;

        /// <summary>
        /// The feet
        /// </summary>
        private decimal feet;

        /// <summary>
        /// The gram
        /// </summary>
        private decimal gram;

        /// <summary>
        /// The inch
        /// </summary>
        private decimal inch;

        /// <summary>
        /// The kilogram
        /// </summary>
        private decimal kilogram;

        /// <summary>
        /// The meter
        /// </summary>
        private decimal meter;


        /// <summary>
        /// Gets or sets the feet.
        /// </summary>
        /// <value>
        /// The feet.
        /// </value>
        public decimal Feet
        {
            get
            {
                return this.feet;
            }
            set
            {
                this.feet = value;
            }
        }

        /// <summary>
        /// Gets or sets the inch.
        /// </summary>
        /// <value>
        /// The inch.
        /// </value>
        public decimal Inch
        {
            get
            {
                return this.inch;
            }
            set
            {
                this.inch = value;
            }
        }

        /// <summary>
        /// Gets or sets the gram.
        /// </summary>
        /// <value>
        /// The gram.
        /// </value>
        public decimal Gram
        {
            get
            {
                return this.gram;
            }
            set
            {
                this.gram = value;
            }
        }

        /// <summary>
        /// Gets or sets the meter.
        /// </summary>
        /// <value>
        /// The meter.
        /// </value>
        public decimal Meter
        {
            get
            {
                return this.meter;
            }
            set
            {
                this.meter = value;
            }
        }

        /// <summary>
        /// Gets or sets the centimeter.
        /// </summary>
        /// <value>
        /// The centimeter.
        /// </value>
        public decimal Centimeter
        {
            get
            {
                return this.centimeter;
            }
            set
            {
                this.centimeter = value;
            }
        }

        /// <summary>
        /// Gets or sets the kilo gram.
        /// </summary>
        /// <value>
        /// The kilo gram.
        /// </value>
        public decimal KiloGram
        {
            get
            {
                return this.kilogram;
            }
            set
            {
                this.kilogram = value;
            }

        }
    }
}
