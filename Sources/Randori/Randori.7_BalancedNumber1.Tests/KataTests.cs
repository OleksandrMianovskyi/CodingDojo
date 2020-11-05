using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7_BalancedNumber1.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void BalancedNumber_InputNumber929_Balanced()
        {
            //arrange
            var number = 929;

            //action
            var result = Kata.BalancedNumber(number);

            //assert
            Assert.AreEqual("Balanced", result);
        }

        [TestMethod]
        public void BalancedNumber_InputNumber923_NotBalanced()
        {
            //arrange
            var number = 923;

            //action
            var result = Kata.BalancedNumber(number);

            //assert
            Assert.AreEqual("Not Balanced", result);
        }

        [TestMethod]
        public void BalancedNumber_InputNumber92_Balanced()
        {
            //arrange
            var number = 92;

            //action
            var result = Kata.BalancedNumber(number);

            //assert
            Assert.AreEqual("Balanced", result);
        }

        [TestMethod]
        public void BalancedNumber_InputNumber1336132_NotBalanced()
        {
            //arrange
            var number = 1336132;

            //action
            var result = Kata.BalancedNumber(number);

            //assert
            Assert.AreEqual("Not Balanced", result);
        }
    }
}
