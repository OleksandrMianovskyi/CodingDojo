using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori.Factorial.Tests
{
    [TestClass]
    public class RepetitionTests
    {
        [TestMethod]
        public void GetString_Return_Hello()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.GetString();

            //assert
            Assert.AreEqual("Hello", result);
        }
    }
}
