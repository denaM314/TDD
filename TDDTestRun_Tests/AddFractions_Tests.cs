using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    public class AddFractions_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddZeroes_EqualsZero()
        {
            var result = new Fraction(0).Plus(new Fraction(0));
            Assert.AreEqual(0, result.IntValue());
        }

        [Test]
        public void FirstFractionZero_SecondNonZero()
        {
            var result = new Fraction(3).Plus(new Fraction(0));
            Assert.AreEqual(3, result.IntValue());
        }

        [Test]
        public void FirstFractionNonZero_SecondZero()
        {
            var result = new Fraction(0).Plus(new Fraction(4));
            Assert.AreEqual(4, result.IntValue());
        }

        [Test]
        public void BothFractionsNonZero()
        {
            var result = new Fraction(3).Plus(new Fraction(9));
            Assert.AreEqual(12, result.IntValue());
        }
    }
}