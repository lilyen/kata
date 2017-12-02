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
        public void TwoWildSame()
        {
            SetReals();

            int[] spins = { 0, 0, 1};

            Assert.AreEqual(10, _class.Fruit(reels, spins));
        }

        [Test]
        public void TwoWildSame_2()
        {
            SetReals();

            int[] spins = { 1, 0, 0 };

            Assert.AreEqual(10, _class.Fruit(reels, spins));
        }

        [Test]
        public void TwoWildSame_NoNeighbor()
        {
            SetReals();

            var result = _class.Fruit(reels, new int[] {0, 1, 0});

            Assert.AreEqual(10, result);
        }

        [Test]
        public void TwoBellSame_NoNeighbor()
        {
            SetReals();

            var result = _class.Fruit(reels, new int[] { 2, 1, 2});

            Assert.AreEqual(8, result);
        }

        [Test]
        public void TwoStar_OneWild()
        {
            SetReals();

            var result = _class.Fruit(reels, new int[] { 0, 1, 1 });

            Assert.AreEqual(18, result);
        }

        [Test]
        public void ThreeWild_chaosReals()
        {
            string[] reel1 = new string[] { "King", "Jack", "Wild", "Bell", "Star", "Seven", "Queen", "Cherry", "Shell", "Bar" };
            string[] reel2 = new string[] { "Star", "Bar", "Jack", "Seven", "Queen", "Wild", "King", "Bell", "Cherry", "Shell" };
            string[] reel3 = new string[] { "King", "Bell", "Jack", "Shell", "Star", "Cherry", "Queen", "Bar", "Wild", "Seven" };
            reels = new List<string[]> { reel1, reel2, reel3 };

            var result = _class.Fruit(reels, new int[] { 2, 5, 8 });

            Assert.AreEqual(100, result);
        }

        [Test]
        public void kataTest_2()
        {
            string[] reel1 = new string[] { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            string[] reel2 = new string[] { "Bar", "Wild", "Queen", "Bell", "King", "Seven", "Cherry", "Jack", "Star", "Shell" };
            string[] reel3 = new string[] { "Bell", "King", "Wild", "Bar", "Seven", "Jack", "Shell", "Cherry", "Queen", "Star" };
            reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 5, 4, 3 };
            Assert.AreEqual(0, _class.Fruit(reels, spins));
        }

        [Test]
        public void kataTest_3()
        {
            string[] reel1 = new string[] { "King", "Cherry", "Bar", "Jack", "Seven", "Queen", "Star", "Shell", "Bell", "Wild" };
            string[] reel2 = new string[] { "Bell", "Seven", "Jack", "Queen", "Bar", "Star", "Shell", "Wild", "Cherry", "King" };
            string[] reel3 = new string[] { "Wild", "King", "Queen", "Seven", "Star", "Bar", "Shell", "Cherry", "Jack", "Bell" };
            reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 0, 0, 1 };
            Assert.AreEqual(3, _class.Fruit(reels, spins));
        }

        [Test]
        public void kataTest_4()
        {
            string[] reel1 = new string[] { "King", "Jack", "Wild", "Bell", "Star", "Seven", "Queen", "Cherry", "Shell", "Bar" };
            string[] reel2 = new string[] { "Star", "Bar", "Jack", "Seven", "Queen", "Wild", "King", "Bell", "Cherry", "Shell" };
            string[] reel3 = new string[] { "King", "Bell", "Jack", "Shell", "Star", "Cherry", "Queen", "Bar", "Wild", "Seven" };
            reels = new List<string[]> { reel1, reel2, reel3 };
            int[] spins = new int[] { 0, 5, 0 };
            Assert.AreEqual(6, _class.Fruit(reels, spins));
        }
    }
}
