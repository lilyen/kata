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

        [TestCase("are", "are", TestName = "word length = 3")]
        [TestCase("i", "i", TestName = "word length < 3")]
        public void Not_Need_Abbreviator_Word(string word, string expected)
        {
            var result = target.Abbreviate(word);
            Assert.AreEqual(expected, word);
        }

        [TestCase("word", "w2d", TestName = "word length = 4")]
        [TestCase("internationalization", "i18n", TestName = "word length > 4")]
        public void Abbreviator_Word(string word, string expected)
        {
            var reault = target.Abbreviate(word);

            Assert.AreEqual(expected, reault);
        }
    }
}
