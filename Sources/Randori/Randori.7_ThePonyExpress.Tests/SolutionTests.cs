using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7_ThePonyExpress.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Riders_InputMiles_2()
        {
            //arrange
            var stations = new [] { 1, 2, 3, 100 };

            //action
            var result = Solution.Riders(stations);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Riders_InputMiles_10()
        {
            //arrange
            var stations = new[] { 100, 400, 500};

            //action
            var result = Solution.Riders(stations);

            //assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Riders_InputMiles_3()
        {
            //arrange
            var stations = new[] { 50, 50};

            //action
            var result = Solution.Riders(stations);

            //assert
            Assert.AreEqual(3, result);
        }
    }
}
