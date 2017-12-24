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
            var pattern = @"[, \s /]+";
            var separateResult = Regex.Split(text, pattern);
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

            var result = bets.Distinct().ToArray();

            Array.Sort(result);

            if (result.Length != N)
            {
                return null;
            }

            return result;
        }
    }
}
