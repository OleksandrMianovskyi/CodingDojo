using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7_TwoOldestAges.Tests
{
    [TestClass]
    public class LargestTwoTests
    {
        [TestMethod]
        public void TwoOldestAges_ArrInt_ArrInt()
        {
            //arrange
            int[] arr =  { 1, 200, 660, 50, 777, 843};
            
            //action
            var result = LargestTwo.TwoOldestAges(arr);

            //assert
            CollectionAssert.AreEqual(new int[]{ 777, 843 }, result);
        }
    }
}
