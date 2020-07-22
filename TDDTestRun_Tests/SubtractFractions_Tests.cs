using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    [TestFixture]
    class SubtractFractions_Tests
    {
        [Test]
        public void Zero_minus_zero()
        {
            var result = new Fraction(0).Minus(new Fraction(0));
            Assert.AreEqual(new Fraction(0), result);
        }

        [Test]
        public void Positive_minus_zero()
        {
            var result = new Fraction(2).Minus(new Fraction(0));
            Assert.AreEqual(new Fraction(2), result);
        }

        [Test]
        public void Zero_minus_positive()
        {
            var result = new Fraction(0).Minus(new Fraction(1));
            Assert.AreEqual(new Fraction(-1), result);
        }

        [Test]
        public void Positive_minus_positive_equals_zero()
        {
            var result = new Fraction(1,2).Minus(new Fraction(1,2));
            Assert.AreEqual(new Fraction(0), result);
        }

        [Test]
        public void Positive_minus_positive_greater_than_zero()
        {
            var result = new Fraction(2, 3).Minus(new Fraction(1, 3));
            Assert.AreEqual(new Fraction(1,3), result);
        }

        [Test]
        public void Negative_minus_positive_equals_negative()
        {
            var result = new Fraction(-2, 5).Minus(new Fraction(1, 5));
            Assert.AreEqual(new Fraction(-3, 5), result);
        }
    }
}
