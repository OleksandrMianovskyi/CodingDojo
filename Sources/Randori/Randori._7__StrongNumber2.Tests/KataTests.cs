using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori._7__StrongNumber2.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void BalancedNumber_InputNumber929_NotStrong()
        {
            //arrange
            var number = "Not Strong !!";

            //action
            var result = Kata.StrongNumber(3);

            //assert
            Assert.AreEqual(number, result);
        }

        [TestMethod]
        public void BalancedNumber_InputNumber2_Strong()
        {
            //arrange
            var number = "STRONG!!!!";

            //action
            var result = Kata.StrongNumber(2);

            //assert
            Assert.AreEqual(number, result);
        }

        [TestMethod]
        public void BalancedNumber_InputNumber0_Strong()
        {
            //arrange
            var number = "Not Strong !!";

            //action
            var result = Kata.StrongNumber(0);

            //assert
            Assert.AreEqual(number, result);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException), "Minus not allowed")]
        //public void BalancedNumber_InputNumberMinus1_Strong()
        //{
        //    //action
        //    Kata.StrongNumber(-1);
        //}

        [TestMethod]
        public void BalancedNumber_InputNumber145_Strong()
        {
            //arrange
            var number = "STRONG!!!!";

            //action
            var result = Kata.StrongNumber(145);

            //assert
            Assert.AreEqual(number, result);
        }
    }
}
