using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    public class WeightSort
    {
        public string orderWeight(string strng)
        {
            var weights = Regex.Split(strng, "\\s+");
            Array.Sort(weights,new WeightCompare());
            return string.Join(" ", weights);
        }
    }

    public class WeightCompare : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            var xSum = x.ToCharArray().Sum(a=>int.Parse(a.ToString()));
            var ySum = y.ToCharArray().Sum(a=> int.Parse(a.ToString()));

            if (xSum>ySum)
            {
                return 1;
            }

            if(xSum < ySum)
            {
                return -1;
            }

            return x.CompareTo(y);
        }
    }
}
