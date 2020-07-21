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
        public void ZeroFractions()
        {
            var result = new Fraction(0).Minus(new Fraction(0));
            Assert.AreEqual(new Fraction(0), result);
        }
    }
}
