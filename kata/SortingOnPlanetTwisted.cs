using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata
{
//Sorting on planet Twisted-3-7
    public class SortingOnPlanetTwisted
    {
        //12,20,72,70,34,46,50,55,62,31" 還沒解完
        public int[] SortTwisted37(int[] array)
        {
            Array.Sort(array);
            for (var i = 0; i < array.Length; i++)
            {
                if (HasTwisted(array[i]))
                {
                    var firstBiggerIndex = FindfirstBiggerIndex(array, GetTwistNum(array[i]));
                    MoveTo(array, i, firstBiggerIndex);
                }
            }

            return array;
        }

        private bool HasTwisted(int value)
        {
            var strValue = Convert.ToString(value);
            char[] hasTwistNum = { '3', '7' };
            return strValue.IndexOfAny(hasTwistNum) >= 0;
        }

        public int GetTwistNum(int value)
        {
            var strValue = Convert.ToString(value);
            char[] hasTwistNum = {'3', '7'};
            for (int index = 0; index < strValue.Length; index ++)
            {
                index = strValue.IndexOfAny(hasTwistNum, index);

                if (index == -1) break;

                if (strValue[index] == '3')
                {
                    strValue = strValue.Remove(index, 1).Insert(index, "7");
                }
                else if (strValue[index] == '7')
                {
                    strValue = strValue.Remove(index, 1).Insert(index, "3");
                }
                
            }

            return Convert.ToInt32(strValue);
        }

        //TODO: 需要修
        private void MoveTo(int[] array, int oringalIndex, int newIndex)
        {
            var targetValue = array[oringalIndex];
            //array[oringalIndex] = Int32.MaxValue;
            
            //把目標移出array
            for (var i = oringalIndex; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }

            if (newIndex == -1)
            {
                var lastIndex = array.Length - 1;
                array[lastIndex] = targetValue;
            }
            else
            {
                if (oringalIndex < newIndex) newIndex -= 1;

                for (var i = array.Length - 1; i > newIndex; i--)
                {
                    array[i] = array[i - 1];
                }

                array[newIndex] = targetValue;
            }
        }

        private int FindfirstBiggerIndex(int[] array, int targetValue)
        {
            var result = -1;

            for (var i = 0; i < array.Length; i++)
            {
                var arrValue = array[i];
                if (arrValue > targetValue)
                {
                    return i;
                }
            }

            return result;
        }
    }
}
