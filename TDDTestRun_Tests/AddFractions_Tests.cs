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
            Assert.IsTrue(result.Equals(new Fraction(0)));
        }

        [Test]
        public void FirstAddendZero_SecondNonZero()
        {
            var result = new Fraction(3).Plus(new Fraction(0));
            Assert.IsTrue(result.Equals(new Fraction(3)));
        }

        [Test]
        public void FirstAddendNonZero_SecondZero()
        {
            var result = new Fraction(0).Plus(new Fraction(4));
            Assert.IsTrue(result.Equals(new Fraction(4)));
        }

        [Test]
        public void BothAddendsNonZero()
        {
            var result = new Fraction(3).Plus(new Fraction(9));
            Assert.IsTrue(result.Equals(new Fraction(12)));
        }

        [Test]
        public void FirstAddendNegative_SecondPositive()
        {
            var result = new Fraction(-4).Plus(new Fraction(1));
            Assert.IsTrue(result.Equals(new Fraction(-3)));
        }

        [Test]
        public void FirstAddendPositive_SecondNegative()
        {
            var result = new Fraction(1).Plus(new Fraction(-5));
            Assert.IsTrue(result.Equals(new Fraction(-4)));
        }

        [Test]
        public void FractionsWithSameDenominator_NonReducable()
        {
            var result = new Fraction(1,5).Plus(new Fraction(2,5));
            Assert.IsTrue(result.Equals(new Fraction(3,5)));
        }

        [Test]
        public void FractionsWithDifferentDenominators_NonReducable()
        {
            var result = new Fraction(1, 2).Plus(new Fraction(1, 3));
            Assert.IsTrue(result.Equals(new Fraction(5, 6)));
        }
    }
}