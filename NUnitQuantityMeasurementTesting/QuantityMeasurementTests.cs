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
            bool result = feet.EqualsCheck(new Feet(0));
            Assert.IsTrue(result);
        }


        [Test]
        public void GivenNullFeet_WhenCompared_ShouldReturnTrue()
        {
            Feet feet = new Feet(null);
            bool result = feet.Equals(new Feet(0));
            Assert.IsTrue(result);
        }
    }
}
