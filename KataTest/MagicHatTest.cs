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
        public void NoBall()
        {
            Assert.AreEqual("Unsure", target.NotSoRandom(0, 0));
        }

        [Test]
        public void OneBlackBall()
        {
            Assert.AreEqual("Black", target.NotSoRandom(1, 0));
        }

        [Test]
        public void OneWhiteBall()
        {
            Assert.AreEqual("White", target.NotSoRandom(0, 1));
        }

        [TestCase("White", 2, 0, TestName = "two ball same, all black")]
        [TestCase("White", 0, 2, TestName = "two ball same, all white")]
        [TestCase("Black", 1, 1, TestName = "two ball different")]
        public void TwoBall(string expected, double black, double white)
        {
            Assert.AreEqual(expected, target.NotSoRandom(black, white));
        }
    }
}
