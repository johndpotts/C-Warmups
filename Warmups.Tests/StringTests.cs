using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class StringTests
    { 
        [TestCase("Bob", "Hello Bob!")]
        [TestCase("Alice", "Hello Alice!")]
        [TestCase("X", "Hello X!")]
        public void SayHiTest(string name, string expected)
        {
            // arrange
            Strings obj = new Strings();

            // act
            string actual = obj.SayHi(name);

            // assert
            Assert.AreEqual(expected, actual);
        }


        //Given two strings, a and b, return the result of putting them together in the order abba, e.g. "Hi" and "Bye" returns "HiByeByeHi". 


        [TestCase("hey", "yo","heyyoyohey")]
        [TestCase("Me", "My","MeMyMyMe")]
        [TestCase("X", "y","XyyX")]
        public void AbbaTest(string a, string b, string expected)
        {
            Strings obj = new Strings();

            string actual = obj.Abba(a, b);

            Assert.AreEqual(expected, actual);

         
        }


    }
}
