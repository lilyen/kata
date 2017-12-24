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
            var expected = new int[] {1, 2, 3, 4, 5};

            var result = target.ValidateBet(5, 90, "1 2 3 4 5");

            Assert.AreEqual(expected, result);
        }
    }
}
