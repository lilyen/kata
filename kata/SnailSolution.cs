using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
    //https://www.codewars.com/kata/521c2db8ddc89b9b7a0000c1/solutions/csharp
    public class SnailSolution
    {
        public int[] Snail(int[][] array)
        {
            var xSite = 0;
            var ySite = 0;
            var length = array[0].Length;
            var isMinus = false;
            var result= new List<int>();
            Console.WriteLine(length);
            if (length == 0)
            {
                return new int[]{};
            }
            for (int i = length-1; i >= 0; i--)
            {
                result.Add(array[xSite][ySite]);
                if(i!=0) ySite++;
            }
            for (int i = length - 2; i >= 0; i--)
            {
                for (int a = i; a >= 0; a--)
                {
                    if (isMinus)
                    {
                        xSite--;
                    }
                    else
                    {
                        xSite++;
                    }
                    result.Add(array[xSite][ySite]);
                }

                for (int a = i; a >= 0; a--)
                {
                    if (!isMinus)
                    {
                        ySite--;
                    }
                    else
                    {
                        ySite++;
                    }
                    result.Add(array[xSite][ySite]);
                }
                isMinus = !isMinus;
            }
            return result.ToArray();
        }
    }
}
