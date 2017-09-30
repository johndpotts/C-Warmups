using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.AreWeInTrouble(aSmile, bSmile);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, true)]
       public void CanSleepInTest(bool isWeekday, bool isVacation, bool expected)
        {
            //arrange
            Conditionals obj = new Conditionals();

            bool actual = obj.CanSleepIn(isWeekday, isVacation);

            Assert.AreEqual(expected, actual);
        }

        /*Given two int values, return their sum.However, if the two values are
            the same, then return double their sum.

        SumDouble(1, 2) -> 3
        SumDouble(3, 2) -> 5
        SumDouble(2, 2) -> 8*/
        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDoubleTest(int a, int b, int expected)
        {
            Conditionals obj = new Conditionals();

            int actual = obj.SumDouble(a, b);

            Assert.AreEqual(actual, expected);
        }
    }
}
