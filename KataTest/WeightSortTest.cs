using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using kata;
using NUnit.Framework;

namespace KataTest
{
    [TestFixture]
    class WeightSortTest
    {
        private WeightSort _weightSort;

        [SetUp]
        public void SetUp()
        {
            _weightSort = new WeightSort();
        }

        [Test]
        public void RemoveWhiteList()
        {
            var result = _weightSort.orderWeight("123   123");
            Assert.AreEqual("123 123",result);
        }

        [Test]
        public void FirstUseSumCompare()
        {
            var result = _weightSort.orderWeight("99 100");
            Assert.AreEqual("100 99", result);
        }

        [Test]
        public void SumSamUseStringCompare()
        {
            var result = _weightSort.orderWeight("90 180");
            Assert.AreEqual("180 90", result);
        }
    }
}
