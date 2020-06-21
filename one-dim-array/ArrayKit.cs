using System;
using System.IO;

namespace one_dim_array
{
    class CustomArrayBase
    {
        protected int[] array;
        protected int Size { get; set; }
        public string SortMode { get; protected set; }

        public CustomArrayBase()
        {
            array = new int[] {5, 8, 10, 12, 24, 11, 9, 5, 8, 1};
            Size = array.Length;
        }

        public int[] GetArray()
        {
            return array;
        }

        public virtual void Sort()
        {
            SortMode = "Встроенная сортировка";
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

    class CustomArray : CustomArrayBase
    {
        private int lowerBound, upperBound;

        public CustomArray(int size, int low, int high)
        {
            Size = size;
            lowerBound = low;
            upperBound = high;
            array = RandomArray();
        }

        private int[] RandomArray()
        {
            var random = new Random();
            int[] randomArray = new int[Size];

            for (var i = 0; i < Size; i++)
            {
                randomArray[i] = random.Next(lowerBound, upperBound + 1);
            }

            return randomArray;
        }
    }

    class CustomArrayFromFile : CustomArrayBase
    {
        public string FilePath { get; private set; }

        public CustomArrayFromFile(string path)
        {
            FilePath = path;

            var stream = new StreamReader(FilePath).ReadLine().Split();
            Size = stream.Length;

            array = new int[Size];
            
            for (var i = 0; i < Size; i++)
            {
                array[i] = Convert.ToInt32(stream[i]);
            }
        }

        override public void Sort()
        {
            SortMode = "Selection2";

            // сортировка методом Selection2
            int i = 0, max, nmax;
            while (i < Size - 1)
            {
                max = array[i];
                nmax = i;
                // цикл внутренних итераций
                int j = i + 1;
                while (j < Size)
                {
                    if (array[j] > max)
                    {
                        max = array[j];
                        nmax = j;
                    }
                    j++;
                }
                // сохранение текущего элемента
                array[nmax] = array[i];
                array[i] = max;
                i++;
            }
        }
    }
}