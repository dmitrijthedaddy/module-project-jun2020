using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_dim_array
{
    static class Histogram
    {
        public static void Plot(int[] values, int count, out double[] x, out int[] y)
        {
            x = new double[count];  // массив границ интервалов
            y = new int[count];     // массив попаданий в интервалы

            // интервалы
            int min = (int)1e6;
            int max = (int)-1e6;
            for (var i = 0; i < values.Length; i++)
            { // нахождение минимума/максимума для границ интерваов
                if (values[i] > max)
                {
                    max = values[i];
                }
                if (values[i] < min)
                {
                    min = values[i];
                }
            }

            var intervalLength = (double)(max - min) / count;            

            for (var i = 1; i < count; i++)
            { // расстановка интервалов
                x[i - 1] = min + intervalLength * i;
            }
            x[count - 1] = max;

            // проверка попаданий
            for (var i = 0; i < values.Length; i++)
            {                
                if (values[i] > min && values[i] <= x[0])
                { // диапазон [min; min + intervalLength]
                    y[0]++;
                }
                else
                { // последующие диапазоны
                    for (var j = 1; j < count; j++)
                    {
                        if (values[i] > x[j - 1] && values[i] <= x[j])
                        {
                            y[j]++;
                        }
                    }
                }
            }
        }
    }
}
