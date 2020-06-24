using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace one_dim_array
{
    public partial class Form1 : Form
    {
        CustomArrayBase array;
        int size = 100, low = 10, high = 99;

        string MainSpline = "Series1", SortedSpline = "Series2";

        public Form1()
        {
            InitializeComponent();
        }

        private bool InputErrorBuster()
        { // проверка ошибок ввода
            try
            {
                size = Convert.ToInt32(elementsCount.Text);
                low = Convert.ToInt32(lowerBoundBox.Text);
                high = Convert.ToInt32(upperBoundBox.Text);
            }
            catch
            {
                MessageBox.Show("Неверные данные на входе.\nПроверьте введённые значения", "Ошибка ввода");
                return false;
            }

            if (low > high)
            {
                MessageBox.Show("Нижняя граница не может быть больше верхней", "Ошибка ввода");
                return false;
            }

            return true;
        }

        private void RefreshOutput()
        {
            outputBox.Clear();
            outputBox.AppendText(String.Join(" ", array.GetArray()));
            chart1.Series[MainSpline].Points.DataBindY(array.GetArray());
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        { // обработчик кнопки "Создать"
            if (!InputErrorBuster()) return;

            array = new CustomArray(size, low, high);

            RefreshOutput();
        }

        private void sortButton_Click(object sender, EventArgs e)
        { // обработчик кнопки "Сортировать"
            array.Sort();
            outputBox.AppendText($"\n\nСортировка методом \"{array.SortMode}\"\n"
                                    + String.Join(" ", array.GetArray()));

            chart1.Series[SortedSpline].Points.DataBindY(array.GetArray());
        }

        private void readFromFileButton_Click(object sender, EventArgs e)
        {
            array = new CustomArrayFromFile("array.txt");

            RefreshOutput();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            outputBox.AppendText($"\n\nМассив сумм соседних элементов оригинального массива\n" 
                                    + String.Join(" ", array.NeighbouringSum()));
        }

        private void plotHistogramButton_Click(object sender, EventArgs e)
        {
            var count = 10;
            double[] x;
            int[] y;

            Histogram.Plot(array.GetArray(), count, out x, out y);

            chart2.Series["Series1"].Points.DataBindXY(x, y);
        }
    }
}
