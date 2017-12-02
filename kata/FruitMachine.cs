using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    public class FruitMachine
    {
        public int Fruit(List<string[]> reels, int[] spins)
        {
            if (reels[0][spins[0]] == reels[1][spins[1]] && reels[0][spins[0]] == reels[2][spins[2]])
            {
                return 100;
            }
            return 0;
        }
    }
}
