using System.Collections.Generic;
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

        [TestMethod]
        public void GetInt_Return_1()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.GetInt();

            //assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetFloat_Return_1()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.GetFloat();

            //assert
            Assert.AreEqual(1.0, result);
        }

        [TestMethod]
        public void Summ_int_int_return_summ()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.Summ();

            //assert
            Assert.AreEqual(4, result);
        }
        
        [TestMethod]
        public void Summ_2_3_return_7()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.Summ(2,3);

            //assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Summ_3_4_return_10()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.Summ(3, 4);

            //assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Diff_6_4_return_2()
        {
            //arrange
            var repetition = new Repetition();

            //action
            var result = repetition.Diff(6, 4);

            //assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Summ_ListInt_return_10()
        {
            //arrange
            var repetition = new Repetition();
            var l = new List<int>{1,23,5,6,7};

            //action
            var result1 = repetition.Summ(l[0], l[1]);

            //assert
            Assert.AreEqual(l[2], result1);
        }
    }
}
