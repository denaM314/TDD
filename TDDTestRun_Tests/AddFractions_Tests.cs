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

        [Test]
        public void SecondAddendDenominatorIsMultipleOfFirstAddendDenominator_NonReducable()
        {
            var result = new Fraction(1, 2).Plus(new Fraction(3, 4));
            Assert.IsTrue(result.Equals(new Fraction(5, 4)));
        }

        [Test]
        public void FractionDenominatorsHaveCommonDivisorButAreNotMultiples()
        {
            var result = new Fraction(1, 4).Plus(new Fraction(1, 6));
            Assert.IsTrue(result.Equals(new Fraction(5, 12)));
        }

        [Test]
        public void FirstAddend_Reduced()
        {
            var result = new Fraction(2, 4).Plus(new Fraction(1, 3));
            Assert.IsTrue(result.Equals(new Fraction(5, 6)));
        }

        [Test]
        public void SecondAddend_Reduced()
        {
            var result = new Fraction(1, 3).Plus(new Fraction(3, 9));
            Assert.IsTrue(result.Equals(new Fraction(2, 3)));
        }

        [Test]
        public void SumResult_Reduced()
        {
            var result = new Fraction(3, 5).Plus(new Fraction(2, 5));
            Assert.IsTrue(result.Equals(new Fraction(1)));
        }

        [Test]
        public void FirstAddendNegative()
        {
            var result = new Fraction(-1, 3).Plus(new Fraction(2, 3));
            Assert.IsTrue(result.Equals(new Fraction(1, 3)));
        }

        [Test]
        public void SecondAddendNegative()
        {
            var result = new Fraction(2, 5).Plus(new Fraction(-1, 5));
            Assert.IsTrue(result.Equals(new Fraction(1, 5)));
        }

        [Test]
        public void FirstAddendNegative_NegativeResult()
        {
            var result = new Fraction(-3, 5).Plus(new Fraction(1, 5));
            Assert.IsTrue(result.Equals(new Fraction(-2, 5)));
        }

        [Test]
        public void FirstAddendNegative_Reduced()
        {
            var result = new Fraction(-2, 4).Plus(new Fraction(1, 3));
            Assert.IsTrue(result.Equals(new Fraction(-1, 6)));
        }

        [Test]
        public void SecondAddendNegative_Reduced()
        {
            var result = new Fraction(1, 3).Plus(new Fraction(-6, 9));
            Assert.IsTrue(result.Equals(new Fraction(-1, 3)));
        }

        [Test]
        public void SecondAddendNegativeDenominator_Reduced()
        {
            var result = new Fraction(1, 3).Plus(new Fraction(6, -9));
            Assert.IsTrue(result.Equals(new Fraction(-1, 3)));
        }
    }
}