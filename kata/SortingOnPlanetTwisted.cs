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
            var indexOf3 = Array.IndexOf(array, 3);
            var indexOf7 = Array.IndexOf(array, 7);
            if (indexOf3 > 0 && indexOf7 > 0)
            {
                Swap(array, indexOf3, indexOf7);
            }
            else if (indexOf7 > 0)
            {
                var firstBiggerIndex = FindfirstBiggerIndex(array, GetTwistNum(7));
                MoveTo(array, indexOf7, firstBiggerIndex);
            }
            else if (indexOf3 > 0)
            {
                var firstBiggerIndex = FindfirstBiggerIndex(array, GetTwistNum(3));
                MoveTo(array, indexOf3, firstBiggerIndex);
            }

            return array;
        }

        public int GetTwistNum(int num)
        {
            if (num == 3)
            {
                return 7;
            } else if (num == 7)
            {
                return 3;
            }

            return -1;
        }

        private void MoveTo(int[] array, int oringalIndex, int newIndex)
        {
            var targetValue = array[oringalIndex];
            array[oringalIndex] = Int32.MaxValue;
            Array.Sort(array);

            if (newIndex == -1)
            {
                var lastIndex = array.Length - 1;
                array[lastIndex] = targetValue;
            }
            else
            {
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
                if (arrValue > targetValue) //TODO: arrValue >= (targetValue+1)
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
