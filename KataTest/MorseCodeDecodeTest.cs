using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kata;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace KataTest
{
    [TestFixture]
    class MorseCodeDecodeTest
    {
        private MorseCodeDecode target = new MorseCodeDecode();
        [Test]
        public void simple()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = target.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }

        [Test]
        public void testSOS()
        {
            try
            {
                string input = "...---...";
                string expected = "SOS";

                string actual = target.Decode(input);

                Assert.AreEqual(expected, actual);
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}
