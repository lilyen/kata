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
    class SnailSolutionTest
    {
        [Test]
        public void zieo()
        {
            var result = new SnailSolution().Snail(new[]{new int[]{}});
            Assert.AreEqual("1", string.Join(",", result));
        }
        [Test]
        public void one()
        {
            var result = new SnailSolution().Snail(new []{
                new[] { 1 },
            });
            Assert.AreEqual("1",string.Join(",",result));
        }

        [Test]
        public void three()
        {
            var result = new SnailSolution().Snail(new[]{
                new[] { 1, 2, 3 },
                new[] { 4, 5, 6 },
                new[] { 7, 8, 9 }
            });
            Assert.AreEqual("1,2,3,6,9,8,7,4,5", string.Join(",", result));
        }
    }
}
