﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDTestRun;

namespace TDDTestRun_Tests
{
    class FractionsEquals_Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AlreadyInLowestTerms()
        {
            Assert.AreEqual(new Fraction(1, 3), new Fraction(1, 3));
        }

        [Test]
        public void ReducedToOne()
        {
            Assert.AreEqual(new Fraction(4, 4), new Fraction(1));
        }

        [Test]
        public void ReducedToZero()
        {
            Assert.AreEqual(new Fraction(0, 5), new Fraction(0));
        }
    }
}