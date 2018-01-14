using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    class AbbreviatorTest
    {
        Abbreviator target = new Abbreviator();

        [Ignore("next")]
        public void Abbreviator_Singal_Word()
        {
            var expected = "i18n";
            var reault = target.Abbreviate("internationalization");

            Assert.Equals(expected, reault);
        }
    }
}
