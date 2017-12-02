using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    public class FruitMachine
    {
        Dictionary<string, int> itemBasicScore = new Dictionary<string, int>()
        {
            {"Wild", 10}, {"Star", 9},
            {"Bell", 8}, {"Shell", 7},
            {"Seven", 6}, {"Cherry", 5},
            {"Bar", 4}, {"King", 3},
            {"Queen", 2}, {"Jack", 1}
        };

        private Dictionary<string, int> scoreBonus = new Dictionary<string, int>()
        {
            {"ThreeItemSame", 10},
            {"TWoItemSame", 1},
            {"TWoItemSameOneWild", 2}
        };

        public int Fruit(List<string[]> reels, int[] spins)
        {
            Dictionary<string, int> spinItemsNum = CountSpinsItem(reels, spins);

            foreach (KeyValuePair<string, int> spinItemNum in spinItemsNum)
            {
                if (spinItemNum.Value == 3)
                {
                    return itemBasicScore[spinItemNum.Key] * scoreBonus["ThreeItemSame"];
                }
                else if(spinItemNum.Value == 2)
                {
                    if (spinItemsNum.ContainsKey("Wild") && (spinItemsNum["Wild"] != 2))
                    {
                        return itemBasicScore[spinItemNum.Key] * scoreBonus["TWoItemSameOneWild"];
                    }
                    else
                    {
                        return itemBasicScore[spinItemNum.Key] * scoreBonus["TWoItemSame"];
                    }
                }
            }

            return 0;
        }

        public Dictionary<string, int> CountSpinsItem(List<string[]> reels, int[] spins)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();

            string tempSpinItem;
            for (int i = 0; i < spins.Length; i++)
            {
                tempSpinItem = reels[i][spins[i]];
                if (result.ContainsKey(tempSpinItem))
                {
                    result[tempSpinItem] = result[tempSpinItem] + 1;
                }
                else
                {
                    result.Add(tempSpinItem, 1);
                }
            }

            return result;
        }
    }
}
