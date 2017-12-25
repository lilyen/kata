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

            if (separateResult.Length != N) return null;
            if (!BetsParseToInt(separateResult, out var bets)) return null;
            if (IsBetsOutstripRange(M, bets)) return null;
            if (IsBetDuplicate(bets)) return null;

            bets.Sort();

            return bets.ToArray();
        }

        private static bool BetsParseToInt(string[] separateResult, out List<int> bets)
        {
            bets = new List<int>();

            try
            {
                foreach (var str in separateResult)
                {
                    bets.Add(Int32.Parse(str));
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private static bool IsBetsOutstripRange(int max, List<int> bets)
        {
            var originalLength = bets.Count;
            var newLength = bets.Count(x => x <= max && x > 0);

            return newLength != originalLength;
        }

        private static bool IsBetDuplicate(List<int> bets)
        {
            var originalLength = bets.Count;
            var newLength = bets.Distinct().Count();

            return newLength != originalLength;
        }
    }
}
