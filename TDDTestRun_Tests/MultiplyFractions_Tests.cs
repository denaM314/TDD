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
    }
}
