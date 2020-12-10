using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7_DisariumNumber_3
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void DisariumNumber_InputNumber89_DisariumNumber()
        {
            //arrange
            var number = 89;

            //action
            var result = Kata.DisariumNumber(number);

            //assert
            Assert.AreEqual("Disarium !!", result);
        }

        [TestMethod]
        public void DisariumNumber_InputNumber929_Not()
        {
            //arrange
            var number = 929;

            //action
            var result = Kata.DisariumNumber(number);

            //assert
            Assert.AreEqual("Not !!", result);
        }

        [TestMethod]
        public void DisariumNumber_InputNumber564_DisariumNumber()
        {
            //arrange
            var number = 564;
            //action
            var result = Kata.DisariumNumber(number);

            //assert
            Assert.AreEqual("Not !!", result);
        }
    }
}