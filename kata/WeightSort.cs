﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata
{
    //https://www.codewars.com/kata/55c6126177c9441a570000cc/solutions/csharp
    public class WeightSort
    {
        public string orderWeight(string strng)
        {
            var weights = Regex.Split(strng, "\\s+");
            Array.Sort(weights,new WeightCompare());
            return string.Join(" ", weights);
        }

        public string orderWeight2(string strng)
        {
            var weights = Regex.Split(strng, "\\s+");
            var results = weights
                .OrderBy(x => x.ToCharArray().Sum(y => int.Parse(y.ToString())))
                .ThenBy(x => x);
            return string.Join(" ", results);
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
