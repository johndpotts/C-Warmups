using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ArrayTests
    {
    

        [TestCase(new int[] { 1, 2, 6 }, new int[] { 0, 2, 6 }, true)]
        [TestCase(new int[] { 6, 1, 2, 3 }, new int[] { 1, 2, 6 }, false)]
        [TestCase(new int[] { 13, 6, 1, 2, 3 }, new int[] { 13, 2, 6 }, true)]
        public void CommonEndTest(int[] a, int[] b, bool expected)
        {
            //arrange
            Arrays obj1 = new Arrays();
            Arrays obj2 = new Arrays();

            //act
            bool answer = obj2.CommonEnd(a,b);
            //assert
            Assert.AreEqual(expected, answer);
        }

        [TestCase(3, new int[] { 3,1,4})]
        [TestCase(6, new int[] { 3, 1, 4,1,5,9 })]
        public void MakePiTest(int a, int[] expected)
        {
            Arrays obj = new Arrays();

            int[] answer = obj.MakePi(a);

            Assert.AreEqual(expected, answer);

        }

        [TestCase(new int []{ 1, 2, 3}, false)]
        [TestCase (new int []{ 1, 2, 3, 1}, true)]
       [TestCase (new int []{ 1, 2, 1}, true)]
       public void SameFirstLastTest(int[] a, bool expected)
          {
            Arrays obj = new Arrays();
            bool answer = obj.SameFirstLast(a);
            Assert.AreEqual(expected, answer);

          }
    }
}
