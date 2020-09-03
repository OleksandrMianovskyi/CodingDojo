using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori.TurkishNumbers.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void GetTurkishNumber_0_sıfır()
        {
            //arrange
            var turkishNumber = new TurkishNumber();

            //action
            var result = turkishNumber.GetTurkishNumber(0);

            //assert
            Assert.AreEqual("sıfır", result);
        }

        [TestMethod]
        public void GetTurkishNumber_22_yirmi_iki()
        {
            //arrange
            var turkishNumber = new TurkishNumber();

            //action
            var result = turkishNumber.GetTurkishNumber(22);

            //assert
            Assert.AreEqual("yirmi iki", result);
        }

        [TestMethod]
        public void GetTurkishNumber_20_yirmi()
        {
            //arrange
            var turkishNumber = new TurkishNumber();

            //action
            var result = turkishNumber.GetTurkishNumber(20);

            //assert
            Assert.AreEqual("yirmi", result);
        }

        [TestMethod]
        public void GetTurkishNumber_37_otuz_()
        {
            //arrange
            var turkishNumber = new TurkishNumber();

            //action
            var result = turkishNumber.GetTurkishNumber(37);

            //assert
            Assert.AreEqual("otuz yedi", result);
        }
    }
}
