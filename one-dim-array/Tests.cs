using System;

namespace one_dim_array
{
    class Tests
    {
        static void Main()
        {
            var customArray = new CustomArray();

            int[] array = customArray.GetArray();
            int[] neighbouringSum = customArray.NeighbouringSum();

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            for (var i = 0; i < neighbouringSum.Length; i++)
            {
                Console.Write(neighbouringSum[i] + " ");
            }

            Console.WriteLine();
        }
    }
}