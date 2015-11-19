﻿using NUnit.Framework;

namespace LeapYearMouseless
{
    [TestFixture]
    public class YearShould
    {
        [Test]
        public void not_be_a_leap_year_if_not_divisible_by_4()
        {
            Assert.IsFalse(new Year(1997).IsLeapYear());
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_4()
        {
            Assert.IsTrue(new Year(1996).IsLeapYear());
        }

        [Test]
        public void be_a_leap_year_if_divisible_by_400()
        {
            Assert.IsTrue(new Year(1600).IsLeapYear());
        }
    }
}