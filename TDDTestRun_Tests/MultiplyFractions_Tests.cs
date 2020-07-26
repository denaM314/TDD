using NUnit.Framework;
using System;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class MultiplyFractions_Tests
    {
        [Test]
        public void Zero_multiplied_by_zero()
        {
            var result = new Fraction(0).MultipliedBy(new Fraction(0));
            Assert.AreEqual(new Fraction(0), result);
        }
        
        [Test]
        public void Zero_multiplied_by_integer()
        {
            var result = new Fraction(0).MultipliedBy(new Fraction(3));
            Assert.AreEqual(new Fraction(0), result);
        }

        [Test]
        public void Integer_multiplied_by_zero()
        {
            var result = new Fraction(3).MultipliedBy(new Fraction(0));
            Assert.AreEqual(new Fraction(0), result);
        }

        [Test]
        public void Integer_multiplied_by_integer()
        {
            var result = new Fraction(3).MultipliedBy(new Fraction(6));
            Assert.AreEqual(new Fraction(18), result);
        }

        [Test]
        public void Integer_multiplied_by_negative_integer()
        {
            var result = new Fraction(2).MultipliedBy(new Fraction(-5));
            Assert.AreEqual(new Fraction(-10), result);
        }

        [Test]
        public void Negative_integer_multiplied_by_negative_integer()
        {
            var result = new Fraction(-4).MultipliedBy(new Fraction(-10));
            Assert.AreEqual(new Fraction(40), result);
        }

        [Test]
        public void Fraction_multiplied_by_a_fraction()
        {
            var result = new Fraction(1,3).MultipliedBy(new Fraction(2,5));
            Assert.AreEqual(new Fraction(2,15), result);
        }

        [Test]
        public void Fraction_multiplied_by_a_negative_fraction()
        {
            var result = new Fraction(3, 7).MultipliedBy(new Fraction(-1, 4));
            Assert.AreEqual(new Fraction(-3, 28), result);
        }

        [Test]
        public void negative_fraction_multiplied_by_a_negative_fraction()
        {
            var result = new Fraction(-5, 3).MultipliedBy(new Fraction(-4, 9));
            Assert.AreEqual(new Fraction(20, 27), result);
        }
    }
}
