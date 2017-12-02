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

        [Test]
        public void NoItemSame()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };

            int[] spins = { 0, 1, 2};

            Assert.AreEqual(0, _class.Fruit(reels, spins));
        }

        [Test]
        public void ThreeItemSame()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };

            int[] spins = { 0, 0, 0 };

            Assert.AreEqual(100, _class.Fruit(reels, spins));
        }

        [Test]
        public void ThreeItemSame_2()
        {
            string[] reel = { "Wild", "Star", "Bell", "Shell", "Seven", "Cherry", "Bar", "King", "Queen", "Jack" };
            List<string[]> reels = new List<string[]> { reel, reel, reel };

            int[] spins = { 1, 1, 1};

            Assert.AreEqual(90, _class.Fruit(reels, spins));
        }
    }
}
