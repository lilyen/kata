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
            Assert.AreEqual(expected, result);
        }

        [TestCase("word", "w2d", TestName = "word length = 4")]
        [TestCase("internationalization", "i18n", TestName = "word length > 4")]
        public void Abbreviator_Word(string word, string expected)
        {
            var reault = target.Abbreviate(word);

            Assert.AreEqual(expected, reault);
        }

        [TestCase("this is an apple", "t2s is an a3e", TestName = "only use space disting word")]
        [TestCase("elephant-rides are really fun!", "e6t-r3s are r4y fun!", TestName = "use diff disting word, end sentence has punctuation")]
        [TestCase("my. dog, isn't feeling very well.", "my. dog, isn't f5g v2y w2l.", TestName = "use diff disting word, end sentence has punctuation")]
        public void Abbreviator_Sentence(string sentence, string expected)
        {
            var result = target.Abbreviate(sentence);

            Assert.AreEqual(expected, result);
        }
    }
}
