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

        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenComparedAndEqual_ShouldReturnEqual()
        {
            Feet feet = new Feet(0);
            int result = feet.EqualsCheck(0);
            Assert.AreEqual(0, result);

        }


        [Test]
        public void GivenNullFeet_WhenCompared_ShouldReturnTrue()
        {
            Feet feet = new Feet(null);
            bool result = feet.Equals(null);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenFeetReference_WhenChecked_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(feet);
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenFeetTypeAndFeetType_WhenAnalyze_ShouldReturnTrue()
        {
            Feet feet = new Feet();
            bool result = feet.Equals(new Feet());
            Assert.IsTrue(result);
        }

        [Test]
        public void GivenFeetValueAndFeetValue_WhenAnalyze_ShouldReturnTrue()
        {
            Feet feet = new Feet(25);
            double actual = feet.EqualsCheck(25);
            Assert.AreEqual(25, actual);
        }

        [Test]
        public void GivenZeroInchAndZeroInch_WhenComparedAndEqual_ShouldReturnEqual()
        {
            Inch inch = new Inch(0);
            int result = inch.EqualsCheck(0);
            Assert.AreEqual(0, result);

        }
    }
}
