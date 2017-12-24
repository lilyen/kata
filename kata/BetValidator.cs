using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    public class BetValidator
    {
        public int[] ValidateBet(int N, int M, string text)
        {
            var separateResult = text.Split(' ');
            var result = new List<int>();

            foreach (var str in separateResult)
            {
                result.Add(Int32.Parse(str));
            }

            return result.ToArray();
        }
    }
}
