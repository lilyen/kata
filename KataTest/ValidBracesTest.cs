using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata;

namespace KataTest
{
    [TestClass]
    public class ValidBracesTest
    {
        private ValidBraces _target = new ValidBraces();
        [TestMethod]
        public void SingleBraces()
        {
            Assert.AreEqual(false, _target.IsValidBraces("(}"));
            Assert.AreEqual(true, _target.IsValidBraces("()"));
        }

        [TestMethod]
        public void DoubleBraces()
        {
            Assert.AreEqual(true, _target.IsValidBraces("()[]{}"));
        }

        [TestMethod]
        public void DoubleBraces_2()
        {
            Assert.AreEqual(true, _target.IsValidBraces("([{}])"));
        }

        [TestMethod]
        public void DoubleBraces_3()
        {
            Assert.AreEqual(false, _target.IsValidBraces("([{]})"));
        }

        [TestMethod]
        public void RightBraces()
        {
            Assert.AreEqual(false, _target.IsValidBraces(")("));
        }

        [TestMethod]
        public void OnlyLeftBraces()
        {
            Assert.AreEqual(false, _target.IsValidBraces("(["));
        }

        [TestMethod]
        public void OtherTest()
        {
            Assert.AreEqual(false, _target.IsValidBraces("[(])"));
            Assert.AreEqual(false, _target.IsValidBraces("[({})](]"));
            Assert.AreEqual(false, _target.IsValidBraces("][({})](]"));
        }
    }
}
