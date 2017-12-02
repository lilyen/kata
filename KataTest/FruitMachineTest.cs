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

        [TestCase(100, 0, TestName = "Wild")]
        [TestCase(90, 1, TestName = "Star")]
        public void ThreeItemSame(int expected, int reelsIndex)
        {
            SetReals();

            int[] spins = { reelsIndex, reelsIndex, reelsIndex };

            Assert.AreEqual(expected, _class.Fruit(reels, spins));
        }
    }
}
