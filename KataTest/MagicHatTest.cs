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
        [TestMethod]
        public void OneBlackBall()
        {
            MagicHat target = new MagicHat();
            string result = target.NotSoRandom(1, 0);

            Assert.AreEqual("Black", result);
        }
    }
}
