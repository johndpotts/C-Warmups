using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            // arrange
            Loops obj = new Loops();

            // act
            string actual = obj.StringTimes(str, n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("dxxxd", 2)]
        [TestCase("xxxx", 3)]
        [TestCase("abcxx", 1)]
        public void CountXXTest(string str, int expected)
        {
            // arrange
            Loops obj = new Loops();

            // act
            int actual = obj.CountXX(str);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
