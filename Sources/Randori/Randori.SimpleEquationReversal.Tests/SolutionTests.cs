using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Randori.SimpleEquationReversal.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Solve_100b_b100()
        {
            //arrange
     
            //action
            var result = Solution.Solve("100*b/y");

            //assert
            Assert.AreEqual("y/b*100", result);
        }

        [TestMethod]
        public void Solve_ab_ba()
        {
            //arrange

            //action
            var result = Solution.Solve("a*b");

            //assert
            Assert.AreEqual("b*a", result);
        }

        [TestMethod]
        public void Solve_30d_d30()
        {
            //arrange

            //action
            var result = Solution.Solve("p/89/15-78/y+95-77-h/65-87-89+d-t/81+a/e-x-u");

            //assert
            Assert.AreEqual("u-x-e/a+81/t-d+89-87-65/h-77-95+y/78-15/89/p", result);
        }
    }
}
