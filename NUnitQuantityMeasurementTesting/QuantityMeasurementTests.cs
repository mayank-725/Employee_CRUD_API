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


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.15
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenOneinchNotEqualsOneFeet_WhenAnalyze_ShouldReturnFalse()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.ConvertInchToFeet();
            Assert.AreNotEqual(1, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.16
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void GivenOneFeetEquals12Inch_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            double actual = feet.ConvertFeetToInch();
            Assert.AreEqual(12, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.17
        ////----------------------------------------------------------------------------------------------------

        [Test]
        public void Given12InchEqualsOneFeet_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch", 12);
            double actual = inch.ConvertInchToFeet();
            Assert.AreEqual(1, actual);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.18
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given3FeetEqual1Yard_WhenAnalyze_ShouldReturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet", 3);
            double actual = feet.ConverFeetintoYard();
            Assert.AreEqual(1, actual);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.19
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given1FeetNotEquals1Yard_WhenChecked_ShouldreturnTrue()
        {
            UnitCheck feet = new UnitCheck("Feet", 1);
            double actual = feet.ConverFeetintoYard();
            Assert.AreNotEqual(1, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.20
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given1InchNotEquals1Yard_WhenChecked_ShouldreturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch", 1);
            double actual = inch.InchToYard();
            Assert.AreNotEqual(1, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.21
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given1YardEquals36Inches_WhenChecked_ShouldreturnTrue()
        {
            UnitCheck yard = new UnitCheck("Yard", 1);
            double actual = yard.YardToInch();
            Assert.AreEqual(36, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.22
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given36InchesEquals1Yard_WhenChecked_ShouldreturnTrue()
        {
            UnitCheck inch = new UnitCheck("Inch", 36);
            double actual = inch.InchToYard();
            Assert.AreEqual(1, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 1.23
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void Given1YardEquals3Feet_WhenChecked_ShouldreturnTrue()
        {
            UnitCheck yard = new UnitCheck("Yard", 1);
            double actual = yard.YardToFeet();
            Assert.AreEqual(3, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.1
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenValueIn_GramClassFunction_WhenAnalyse_ReturnEqual()
        {
            UnitCheck unit=new UnitCheck("Gram", 0);
            Gram gram = new Gram(0);
            double actual = gram.ValueCheck();
            double expected = unit.EqualsCheck();
            Assert.AreEqual(expected, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.2
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenNullTo_GramClassEqualsFunction_WhenAnalyse_ReturnTrue()
        {
            Gram gram = new Gram();
            bool actual = gram.Equals(null);
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.3
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenReferenceTo_GramClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Gram gram = new Gram();
            bool actual = gram.Equals(gram);
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.4
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenObjectOfGramType_EqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Gram gram = new Gram();
            bool actual = gram.Equals(new Gram());
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.5
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenValueTo_GramClass_WhenAnalyse_ReturnEqual()
        {
            Gram gram = new Gram(10);
            double actual = gram.ValueCheck();
            UnitCheck unit = new UnitCheck("Gram", 10);
            double expected = unit.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.6
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenValueIn_KiloGramClassFunction_WhenAnalyse_ReturnEqual()
        {
            KiloGram kilogram = new KiloGram(0);
            UnitCheck unit = new UnitCheck();
            double actual = kilogram.CheckForEqualValue();
            double expected = unit.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }


        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.7
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenNullTo_KiloGramClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            KiloGram kilogram = new KiloGram(0);
            bool actual = kilogram.Equals(null);
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.8
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenReferenceTo_KiloGramClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            KiloGram kilogram = new KiloGram(0);
            bool actual = kilogram.Equals(kilogram);
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.9
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenObjectTo_KiloGramClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            KiloGram kilogram = new KiloGram(0);
            bool actual = kilogram.Equals(new KiloGram());
            Assert.IsTrue(actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 2.10
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenValueTo_KiloGramClass_WhenAnalyse_ReturnEqual()
        {
            UnitCheck unit = new UnitCheck("KiloGram", 10);
            KiloGram kilogram = new KiloGram(10);
            double actual = kilogram.CheckForEqualValue();
            double expected = unit.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 3.0
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenValueIn_CelciusClassFunction_WhenAnalyse_ReturnEqual()
        {
            UnitCheck unit = new UnitCheck("Celcius", 0);
            Celsius celcius = new Celsius(0);
            double actual = celcius.CheckForEqualValue();
            double expected = unit.CheckEqualValue();
            Assert.AreEqual(expected, actual);
        }

        ////----------------------------------------------------------------------------------------------------
        ////                                     TestCase 3.1
        ////----------------------------------------------------------------------------------------------------
        [Test]
        public void GivenNullTo_CelciusClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Celsius celsius = new Celsius(0);
            bool actual = celsius.Equals(null);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenReferenceTo_CelciusClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Celsius celsius = new Celsius(0);
            bool actual = celsius.Equals(celsius);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectTo_CelciusClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Celsius celsius = new Celsius(0);
            bool actual = celsius.Equals(new Celsius());
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenValueTo_CelciusClass_WhenAnalyse_ReturnEqual()
        {
          UnitCheck unit = new UnitCheck("Celcius", 0);
            Celsius celsius = new Celsius(0);
            double actual = celsius.CheckForEqualValue();
            double expected = unit.CheckForEqualValue();
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenNullTo_FarenheitClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Fahrenheit farenheit = new Fahrenheit(0);
            bool actual = farenheit.Equals(null);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenReferenceTo_FarenheitClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Fahrenheit farenheit = new Fahrenheit(0);
            bool actual = farenheit.Equals(farenheit);
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenObjectTo_FarenheitClassEqualsMethod_WhenAnalyse_ReturnTrue()
        {
            Fahrenheit farenheit = new Fahrenheit(0);
            bool actual = farenheit.Equals(new Fahrenheit());
            Assert.IsTrue(actual);
        }

        [Test]
        public void GivenValueTo_FarenheitClass_WhenAnalyse_ReturnEqual()
        {
            UnitCheck unitCheck = new UnitCheck("Farenheit", 10);
            Fahrenheit farenheit = new Fahrenheit(10);
            double actual = farenheit.CheckForEqualValue();
            double expected = unitCheck.CheckEqualValue();
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Given1KGWith1000GRAM_WhenAnaylse_returnEqual()
        {
            UnitCheck unit = new UnitCheck("Kilogram", 1);
            double actual = unit.ConvertKiloGramToGram();
            Gram gram = new Gram(1000);
            double expected = gram.ValueCheck();
            Assert.AreEqual(expected, actual);
        }
    }
}
