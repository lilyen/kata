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
            
            if (IsBetsOutstripRange(M, bets)) return null;

            bets.Sort();

            if (IsBetDuplicate(bets)) return null;

            return bets.ToArray();
        }

        private static bool IsBetsOutstripRange(int max, List<int> bets)
        {
            foreach (var bet in bets)
            {
                if (bet > max || bet <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsBetDuplicate(List<int> bets)
        {
            var originalLength = bets.Count;
            var newLength = bets.Distinct().Count();

            return newLength != originalLength;
        }
    }
}
