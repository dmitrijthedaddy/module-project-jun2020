using System;

namespace one_dim_array
{
    class Tests
    {
        static void Main()
        {
            var customArray = new CustomArray(50, 1, 90);

            int[] array = customArray.GetArray();
            int[] neighbouringSum = customArray.NeighbouringSum();

            for (var i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
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