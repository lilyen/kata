using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using kata;
using Assert = NUnit.Framework.Assert;

namespace KataTest
{
    [TestFixture]
    class MagicHatTest
    {
        MagicHat target = new MagicHat();

        [Test]
        public void NoMarble()
        {
            Assert.AreEqual("Unsure", target.NotSoRandom(0, 0));
        }

        [Test]
        public void OneBlackMarble()
        {
            Assert.AreEqual("Black", target.NotSoRandom(1, 0));
        }

        [Test]
        public void OneWhiteMarble()
        {
            Assert.AreEqual("White", target.NotSoRandom(0, 1));
        }

        [TestCase("White", 2, 0, TestName = "two marbles same, all black")]
        [TestCase("White", 0, 2, TestName = "two marbles same, all white")]
        [TestCase("Black", 1, 1, TestName = "two marbles different")]
        public void TwoMarble(string expected, double black, double white)
        {
            Assert.AreEqual(expected, target.NotSoRandom(black, white));
        }

        [TestCase("White", 0, 3, TestName = "three marbles same, all white")]
        [TestCase("Black", 3, 0, TestName = "three marbles same, all black")]
        public void ThreeMarble(string expected, double black, double white)
        {
            Assert.AreEqual(expected, target.NotSoRandom(black, white));
        }
    }
}
