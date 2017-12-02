using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using kata;

namespace KataTest
{
    /// <summary>
    /// Summary description for FruitMachine
    /// </summary>
    [TestFixture]
    public class FruitMachineTest
    {
        FruitMachine _class = new FruitMachine();
        private string[] reel;
        private List<string[]> reels;

        private void SetReals()
        {
            reel = new string[]{ "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            reels = new List<string[]> { reel, reel, reel };
        }

        [Test]
        public void NoItemSame()
        {
            SetReals();

            int[] spins = { 0, 1, 2};

            Assert.AreEqual(0, _class.Fruit(reels, spins));
        }

        [TestCase(100, 0, TestName = "three Wild same")]
        [TestCase(90, 1, TestName = "three Star same")]
        [TestCase(80, 2, TestName = "three Bell same")]
        [TestCase(70, 3, TestName = "three Shell same")]
        [TestCase(60, 4, TestName = "three Seven same")]
        [TestCase(50, 5, TestName = "three Cherry same")]
        [TestCase(40, 6, TestName = "three Bar same")]
        [TestCase(30, 7, TestName = "three King same")]
        [TestCase(20, 8, TestName = "three Queen same")]
        [TestCase(10, 9, TestName = "three Jack same")]
        public void ThreeItemSame(int expected, int reelsIndex)
        {
            SetReals();

            int[] spins = { reelsIndex, reelsIndex, reelsIndex };

            Assert.AreEqual(expected, _class.Fruit(reels, spins));
        }

        [Test]
        public void TwoItemSame()
        {
            SetReals();

            int[] spins = { 0, 0, 1};

            Assert.AreEqual(10, _class.Fruit(reels, spins));
        }

        [Test]
        public void TwoItemSame_NoNeighbor()
        {
            SetReals();

            int[] spins = { 1, 0, 0 };

            Assert.AreEqual(10, _class.Fruit(reels, spins));
        }
    }
}
