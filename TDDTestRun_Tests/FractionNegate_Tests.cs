using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class FractionNegate_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Negate_zero()
        {
            var result = new Fraction(0).Negate();
            Assert.AreEqual(new Fraction(0), result);
        }

        [Test]
        public void Negate_positive_integer()
        {
            var result = new Fraction(1).Negate();
            Assert.AreEqual(new Fraction(-1), result);
        }

        [Test]
        public void Negate_negative_integer()
        {
            var result = new Fraction(-8).Negate();
            Assert.AreEqual(new Fraction(8), result);
        }
    }
}
