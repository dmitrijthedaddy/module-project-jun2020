using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_integration
{
    public abstract class IntegrationMethods
    { // Методы: средних прямоугольников, трапеций, Симпсона 3/8
        abstract public double Y(double x);

        abstract public double IntY(double low, double hi);

        public double MidRectMethod(double low, double intStep, double stepCount)
        {
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                result += Y(x - intStep / 2) * intStep;
                x += intStep;
            }

            return result;
        }

        public double TrapeziaMethod(double low, double intStep, double stepCount) 
        {
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                result += (Y(x) + Y(x - intStep)) / 2 * intStep;
                x += intStep;
            }

            return result;
        }

        public double Simspon2Method(double low, double intStep, double stepCount)
        {
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                double a = Y(x - intStep);
                double b = 3 * Y((2 * (x - intStep) + x) / 3);
                double c = 3 * Y((x - intStep + 2 * x) / 3);
                result += (a + b + c + Y(x)) / 8 * intStep;
            }

            return result;
        }
    }
}