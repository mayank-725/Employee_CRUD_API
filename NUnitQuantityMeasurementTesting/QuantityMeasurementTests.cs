using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitQuantityMeasurementTesting
{
    public class QuantityMeasurementTests
    {
        [SetUp]
        public void Setup()
        {
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.1
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenComparedAndEqual_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            int result = feet.EqualsCheck(0);
            Assert.AreEqual(0, result);

        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.2
        ////----------------------------------------------------------------------------------------------------

        /// <summary>
        /// Givens the null feet when compared should return true.
        /// </summary>
        [Test]
        public void GivenNullFeet_WhenCompared_ShouldReturnTrue()
        {
            Feet feet = new Feet(null);
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.3
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenFeetReference_WhenChecked_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.4
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenFeetTypeAndFeetType_WhenAnalyze_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.5
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenFeetValueAndFeetValue_WhenAnalyze_ShouldReturnTrue()
        {
            Feet feet = new Feet(25);
            double actual = feet.EqualsCheck(25);
            Assert.AreEqual(25, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.6
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenZeroInchAndZeroInch_WhenComparedAndEqual_ShouldReturnEqual()
        {
            Inch inch = new Inch(0);
            double result = inch.CheckValue();
            Assert.AreEqual(0, result);

        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.7
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenNullInch_WhenCompared_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.8
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenInchReference_WhenChecked_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.9
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenInchTypeAndInchType_WhenAnalyze_ShouldReturnTrue()
        {
            Inch inch = new Inch();
            bool result = inch.Equals(new Inch());
            Assert.IsTrue(result);
        }
    }
}
