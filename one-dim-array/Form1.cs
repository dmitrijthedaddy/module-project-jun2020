using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void createObjectButton_Click(object sender, EventArgs e)
        { // обработчик кнопки "Создать"
            if (!InputErrorBuster()) return;

            array = new CustomArray(size, low, high);
            outputBox.AppendText(String.Join(" ", array.GetArray()));

            chart1.Series[MainSpline].Points.DataBindY(array.GetArray());
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

        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            outputBox.AppendText($"\n\nМассив сумм соседних элементов оригинального массива\n" 
                                    + String.Join(" ", array.NeighbouringSum()));
        }

        private void plotHistogramButton_Click(object sender, EventArgs e)
        {

        }
    }
}
