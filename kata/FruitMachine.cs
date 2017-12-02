﻿using System;
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

        Dictionary<string, int> TwoItemMatchScore = new Dictionary<string, int>()
        {
            {"Wild", 10}, {"Star", 9},
            {"Bell", 8}, {"Shell", 7},
            {"Seven", 6}, {"Cherry", 5},
            {"Bar", 4}, {"King", 3},
            {"Queen", 2}, {"Jack", 1}
        };

        public int Fruit(List<string[]> reels, int[] spins)
        {
            Dictionary<string, int> spinItemsNum = new Dictionary<string, int>();

            string tempSpinItem;
            for (int i = 0; i < 3; i++)
            {
                tempSpinItem = reels[i][spins[i]];
                if (spinItemsNum.ContainsKey(tempSpinItem))
                {
                    spinItemsNum[tempSpinItem] = spinItemsNum[tempSpinItem] + 1;
                }
                else
                {
                    spinItemsNum.Add(tempSpinItem, 1);
                }
            }

            foreach (KeyValuePair<string, int> spinItemNum in spinItemsNum)
            {
                if (spinItemNum.Value == 3)
                {
                    return ThreeItemMatchScore[spinItemNum.Key];
                }
                else if(spinItemNum.Value == 2)
                {
                    return TwoItemMatchScore[spinItemNum.Key];
                }
            }

            return 0;
        }
    }
}
