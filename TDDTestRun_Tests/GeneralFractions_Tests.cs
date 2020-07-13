using System;
using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class GeneralFractions_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ZeroDenominator()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Fraction(2, 0));
        }

        [Test]
        public void FractionReducedOnCreation()
        {
            var result = new Fraction(2, 6);
            Assert.IsTrue(result.Equals(new Fraction(1,3)));
        }

        [Test]
        public void FractionReducedEqualToOneOnCreation()
        {
            var result = new Fraction(3, 3);
            Assert.IsTrue(result.Equals(new Fraction(1)));
        }

        [Test]
        public void NegativeDenominator_MadeIntoNegativeNumerator()
        {
            var result = new Fraction(2, -3);
            Assert.IsTrue(result.Equals(new Fraction(-2, 3)));
        }
    }
}
