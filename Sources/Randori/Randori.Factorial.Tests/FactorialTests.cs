using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;

namespace Randori.Factorial.Tests
{
    [TestClass]
    public class FactorialTests
    {
        [TestMethod]
        public void Calculate_1_1()
        {
            //arrange
            var factorial = new Factorial();

            //action
            var result = factorial.Calculate(1);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_3_6()
        {
            //arrange
            var factorial = new Factorial();

            //action
            var result = factorial.Calculate(3);

            //assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Calculate_5_120()
        {
            //arrange
            var factorial = new Factorial();

            //action
            var result = factorial.Calculate(5);

            //assert
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        public void Calculate_0_1()
        {
            //arrange
            var factorial = new Factorial();

            //action
            var result = factorial.Calculate(0);

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Calculate_100()
        {
            //arrange
            var factorial = new Factorial();
            var parsed = BigInteger.Parse("93326215443944152681699238856266700490715968264381621468592963895217599993229915608941463976156518286253697920827223758251185210916864000000000000000000000000");

            //action
            var result = factorial.Calculate(100);

            //assert
            Assert.AreEqual(parsed, result);
        }
    }
}
