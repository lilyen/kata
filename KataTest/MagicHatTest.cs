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
        [Test]
        public void NoBall()
        {
            MagicHat target = new MagicHat();
            string result = target.NotSoRandom(0, 0);

            Assert.AreEqual("Unsure", result);
        }

        [Test]
        public void OneBlackBall()
        {
            MagicHat target = new MagicHat();
            string result = target.NotSoRandom(1, 0);

            Assert.AreEqual("Black", result);
        }

        [Test]
        public void OneWhiteBall()
        {
            MagicHat target = new MagicHat();
            string result = target.NotSoRandom(0, 1);

            Assert.AreEqual("White", result);
        }
    }
}
