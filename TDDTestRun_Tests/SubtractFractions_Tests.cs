﻿using System;
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
        public void ZeroIntegers()
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
    }
}
