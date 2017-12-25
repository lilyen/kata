using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    public class BetValidator
    {
        public int[] ValidateBet(int N, int M, string text)
        {
            var separateResult = Regex.Split(text, @"[, \s /]+");
            if (separateResult.Length != N)
            {
                return null;
            }

            var bets = new List<int>();

            try
            {
                foreach (var str in separateResult)
                {
                    bets.Add(Int32.Parse(str));
                }
            }
            catch (Exception e)
            {
                return null;
            }
            
            foreach (var bet in bets)
            {
                if (bet > M || bet <= 0)
                {
                    return null;
                }
            }

            if (IsBetDuplicate(bets)) return null;

            var result = bets.ToArray();
            Array.Sort(result);

            return result;
        }

        private static bool IsBetDuplicate(List<int> bets)
        {
            int originalLength = bets.Count;
            var newLength = bets.Distinct().Count();

            return newLength != originalLength;
        }
    }
}
