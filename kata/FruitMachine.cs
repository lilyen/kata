using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    public class FruitMachine
    {
        Dictionary<string, int> ThreeItemMatchScore = new Dictionary<string, int>()
        {
            {"Wild", 100}, {"Star", 90},
            {"Bell", 80}, {"Shell", 70},
            {"Seven", 60}, {"Cherry", 50},
            {"Bar", 40}, {"King", 30},
            {"Queen", 20}, {"Jack", 10}
        };
        public int Fruit(List<string[]> reels, int[] spins)
        {
            if (reels[0][spins[0]] == reels[1][spins[1]] && reels[0][spins[0]] == reels[2][spins[2]])
            {
                return ThreeItemMatchScore[reels[0][spins[0]]];
            }
            return 0;
        }
    }
}
