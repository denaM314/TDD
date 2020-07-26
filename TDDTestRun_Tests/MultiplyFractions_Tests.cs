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
    }
}
