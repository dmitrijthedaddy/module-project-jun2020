using System;

namespace one_dim_array
{
    class CustomArray
    {
        protected int[] array;
        protected int Size { get; set; }
        public string SortMode { get; private set; }

        public CustomArray()
        {
            array = new int[] {5, 8, 10, 12, 24, 11, 9, 5, 8, 1};
            Size = array.Length;
        }

        public int[] GetArray()
        {
            return array;
        }

        public void Sort()
        {
            Array.Sort(array);
            Array.Reverse(array);
        }

        public int[] NeighbouringSum()
        {
            int[] neighbouringSum = new int[Size - 1];

            for (var i = 0; i < Size - 1; i++)
            {
                neighbouringSum[i] = array[i] + array[i + 1];
            }

            return neighbouringSum;
        }
    }
}