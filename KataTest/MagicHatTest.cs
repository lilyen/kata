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
    }
}
