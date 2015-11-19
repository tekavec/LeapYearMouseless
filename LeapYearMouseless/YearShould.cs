using NUnit.Framework;

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
    }
}