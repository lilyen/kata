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
            var unitsDigit = value % 10;
            return unitsDigit == 3 || unitsDigit == 7;
        }

        public int GetTwistNum(int value)
        {
            var unitsDigit = value % 10;
            if (unitsDigit == 3)
            {
                return (value / 10) * 10 + 7;
            } else if (unitsDigit == 7)
            {
                return (value / 10) * 10 + 3;
            }

            return -1;
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

        private void Swap(int[] array, int indexOf3, int indexOf7)
        {
            var tempValue = array[indexOf3];
            array[indexOf3] = array[indexOf7];
            array[indexOf7] = tempValue;
        }
    }
}
