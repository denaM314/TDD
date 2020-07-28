using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class DivideFractions
    {
        [Test]
        public void One_dividedby_one()
        {
            var result = new Fraction(1).DividedBy(new Fraction(1));
            Assert.AreEqual(new Fraction(1), result);
        }

        [Test]
        public void divisible_integer_dividedby_integer()
        {
            var result = new Fraction(6).DividedBy(new Fraction(3));
            Assert.AreEqual(new Fraction(2), result);
        }

        [Test]
        public void nondivisible_integer_dividedby_integer()
        {
            var result = new Fraction(7).DividedBy(new Fraction(2));
            Assert.AreEqual(new Fraction(7,2), result);
        }

        [Test]
        public void Integer_dividedby_larger_integer()
        {
            var result = new Fraction(3).DividedBy(new Fraction(8));
            Assert.AreEqual(new Fraction(3, 8), result);
        }
    }
}
