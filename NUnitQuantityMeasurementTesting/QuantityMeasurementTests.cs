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
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.3
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenFeetReference_WhenChecked_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.4
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenFeetTypeAndFeetType_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet");
            bool result = feet.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.5
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenFeetValueAndFeetValue_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet", 25);
            double actual = feet.EqualsCheck();
            Assert.AreEqual(25, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.6
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenZeroInchAndZeroInch_WhenComparedAndEqual_ShouldReturnEqual()
        {
            UnitCheck inch = new UnitCheck("Inch", 0);
            double result = inch.EqualsCheck();
            Assert.AreEqual(0, result);

        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.7
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenNullInch_WhenCompared_ShouldReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch",0);
            bool result = inch.Equals(null);
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.8
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenInchReference_WhenChecked_ShouldReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(inch);
            Assert.IsTrue(result);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.9
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenInchTypeAndInchType_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch");
            bool result = inch.Equals(new UnitCheck());
            Assert.IsTrue(result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.10
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenInchValueAndInchValue_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch", 43);
            double result = inch.EqualsCheck();
            Assert.AreEqual(43, result);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.13
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenZeroFeetAndZeroInch_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet", 10);
            double expected = feet.EqualsCheck();
            UnitCheck inch = new UnitCheck("Inch", 10);
            double actual = inch.EqualsCheck();
            Assert.AreEqual(expected, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.14
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenOneFeetAnd1inch_WhenAnalyze_ShouldReturnFalse()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            double actual = feet.ConvertFeetToInch();
            Assert.AreNotEqual(1, actual);
        }
    }
}
