using System;
using System.Linq;

namespace Static_004
{
    static class ArrayOperation
    {
        public static int[] OurSort(this int[] array)
        {
            var sortedArray = from i in array
                              orderby i
                              select i;
            array = sortedArray.ToArray();
            return array;
        }
        public static int[] CreateArray(int elements)
        {
            Random random = new Random();
            int[] array = new int [elements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            return array;
        }
    }
}
