using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LogicTests
    {
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatPartyTest(int cigars, bool isWeekend, bool expected)
        {
            // arrange
            Logic obj = new Logic();
            
            // act
            bool actual = obj.GreatParty(cigars, isWeekend);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 8, 0)]
        [TestCase(9, 2, 0)]
        [TestCase(3, 4, 1)]
        [TestCase(6, 9, 2)]
        public void CanHazTableTest(int yourStyle, int dateStyle, int expected)
        {
            Logic obj = new Logic();

            int actual = obj.CanHazTable(yourStyle, dateStyle);

            Assert.AreEqual(expected, actual);
        }
    }
}
