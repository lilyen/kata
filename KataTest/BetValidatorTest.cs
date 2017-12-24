using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using kata;

namespace KataTest
{
    [TestFixture]
    class BetValidatorTest
    {
        private BetValidator target = new BetValidator();

        [Test]
        public void SeparatedbySingalCharacter()
        {
            Assert.AreEqual(new int[] {1, 2, 3, 4, 5}, target.ValidateBet(5, 90, "1 2 3 4 5"));
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, target.ValidateBet(5, 90, "1,2,3,4,5"));
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, target.ValidateBet(5, 90, "1/2/3/4/5"));
        }

        [Test]
        public void SeparatedbyIrregularCharacter()
        {
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, target.ValidateBet(5, 90, "1 2/3,4 5"));
            Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, target.ValidateBet(5, 90, "1 2/ 3 ,4 5"));
        }

        [Test]
        public void SortResult()
        {
            Assert.AreEqual(new int[] { 1, 2, 4, 5, 10 }, target.ValidateBet(5, 90, "1 2 10 4 5"));
        }

        [Test]
        public void BetsAmountNoValidator()
        {
            Assert.AreEqual(null, target.ValidateBet(5, 90, "1 2 3 4"));
        }

        [Test]
        public void BetLimitNoValidator()
        {
            Assert.AreEqual(null, target.ValidateBet(5, 90, "1 2 95 4 10"));
            Assert.AreEqual(null, target.ValidateBet(5, 90, "1 2 0 4 10"));
            Assert.AreEqual(null, target.ValidateBet(5, 90, "1 2 -1 4 10"));
            Assert.AreEqual(null, target.ValidateBet(5, 9, "1 2 5 4 10"));
        }

        [Test]
        public void BetFormatNoValidator()
        {
            Assert.AreEqual(null, target.ValidateBet(5, 90, "1 2 3; 4 5"));
        }
    }
}
