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

            for (int i = 0; i < stepCount; i++)
            {
                result += Y(x - intStep / 2) * intStep;
                x += intStep;
            }

            return result;
        }

        public double TrapeziaMethod(double low, double intStep, double stepCount) 
        {
            double result = 0, x = low;

            for (int i = 0; i < stepCount; i++)
            {
                result += (Y(x) + Y(x - intStep)) / 2 * intStep;
                x += intStep;
            }

            return result;
        }
    }
}
