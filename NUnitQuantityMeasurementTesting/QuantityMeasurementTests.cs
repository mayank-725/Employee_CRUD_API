using NUnit.Framework;

namespace NUnitQuantityMeasurementTesting
{
    public class QuantityMeasurementTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Feet feet = new Feet();
            int feet = 0;
            int expected = 0;
            int actual = feet.FeetLength(0);
            Assert.AreEqual(expected, actual);
        }
    }
}