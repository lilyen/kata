using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            var result = new List<int>();

            foreach (var str in separateResult)
            {
                result.Add(Int32.Parse(str));
            }

            foreach (var bet in result)
            {
                if (bet > M)
                {
                    return null;
                }
            }

            return result.ToArray();
        }
    }
}
