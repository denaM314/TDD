using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class FractionsEquals_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AlreadyInLowestTerms()
        {
            Assert.AreEqual(new Fraction(1, 3), new Fraction(1, 3));
        }

        [Test]
        public void ReducedFraction()
        {
            Assert.AreEqual(new Fraction(12, 9), new Fraction(4, 3));
        }

        [Test]
        public void ReducedToWholeNumber()
        {
            Assert.AreEqual(new Fraction(8, 4), new Fraction(2));
        }

        [Test]
        public void ReducedToOne()
        {
            Assert.AreEqual(new Fraction(4, 4), new Fraction(1));
        }

        [Test]
        public void ReducedToZero()
        {
            Assert.AreEqual(new Fraction(0, 5), new Fraction(0));
        }

        [Test]
        public void DoubleNegative()
        {
            Assert.AreEqual(new Fraction(-3, -4), new Fraction(3, 4));
        }
    }
}
