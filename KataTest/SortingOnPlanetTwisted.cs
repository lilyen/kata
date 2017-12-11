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
    class SortingOnPlanetTwistedTest
    {
        private SortingOnPlanetTwisted target = new SortingOnPlanetTwisted();

        [Test]
        public void sortWithNoTwist()
        {
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 4, 5, 6, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 2, 4, 5, 6, 8, 9 })));
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 4, 5, 6, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 4, 5, 2, 9, 8, 6 })));
        }

        [Test]
        public void sortWithTwist37()
        {
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 })));
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
        }

        [Test]
        public void sortWithOnly3Or7()
        {
            Assert.AreEqual(string.Join(",", new[] { 1, 7, 4}), string.Join(",", target.SortTwisted37(new[] { 1, 4, 7})));
            Assert.AreEqual(string.Join(",", new[] { 1, 5, 3}), string.Join(",", target.SortTwisted37(new[] { 1, 3, 5})));
            Assert.AreEqual(string.Join(",", new[] { 1, 5, 3, 8 }), string.Join(",", target.SortTwisted37(new[] { 1, 5, 3, 8 })));
            //Assert.AreEqual(string.Join(",", new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
        }

        [Test]
        public void KataTests()
        {
            Assert.AreEqual(string.Join(",", new[] { 1, 2, 7, 4, 5, 6, 3, 8, 9 }), string.Join(",", target.SortTwisted37(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })));
            Assert.AreEqual(string.Join(",", new[] { 12, 14, 13 }), string.Join(",", target.SortTwisted37(new[] { 12, 13, 14 })));
            Assert.AreEqual(string.Join(",", new[] { 2, 7, 4, 3, 9 }), string.Join(",", target.SortTwisted37(new[] { 9, 2, 4, 7, 3 })));
        }

    }
}
