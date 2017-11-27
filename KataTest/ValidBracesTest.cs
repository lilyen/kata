using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata;

namespace KataTest
{
    [TestClass]
    public class ValidBracesTest
    {
        private ValidBraces target = new ValidBraces();
        [TestMethod]
        public void singleBraces()
        {
            Assert.AreEqual(true, target.IsValidBraces(""));
            Assert.AreEqual(false, target.IsValidBraces("(}"));
            Assert.AreEqual(true, target.IsValidBraces("()"));
        }

        [TestMethod]
        public void DoubleBraces()
        {
            Assert.AreEqual(true, target.IsValidBraces("()[]{}"));
        }

        [TestMethod]
        public void DoubleBraces_2()
        {
            Assert.AreEqual(true, target.IsValidBraces("([{}])"));
        }

        [TestMethod]
        public void DoubleBraces_3()
        {
            Assert.AreEqual(false, target.IsValidBraces("([{]})"));
        }

        [TestMethod]
        public void rightBraces()
        {
            Assert.AreEqual(false, target.IsValidBraces(")("));
        }

        [TestMethod]
        public void rightBraces_2()
        {
            Assert.AreEqual(false, target.IsValidBraces("(["));
        }

        [TestMethod]
        public void otherTest()
        {
            Assert.AreEqual(false, target.IsValidBraces("[(])"));
            Assert.AreEqual(false, target.IsValidBraces("[({})](]"));
            Assert.AreEqual(false, target.IsValidBraces("][({})](]"));
        }
    }
}
