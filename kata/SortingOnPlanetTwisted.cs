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
                swap(array, indexOf3, indexOf7);
            }
            return array;
        }

        private void swap(int[] array, int indexOf3, int indexOf7)
        {
            var tempValue = array[indexOf3];
            array[indexOf3] = array[indexOf7];
            array[indexOf7] = tempValue;
        }
    }
}
