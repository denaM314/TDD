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
    }
}
