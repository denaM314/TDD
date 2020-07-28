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
    }
}
