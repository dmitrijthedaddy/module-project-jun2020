using System;

namespace function_integration
{
    public abstract class IntegrationMethods
    { // методы: средних прямоугольников, трапеций, Симпсона 3/8

        // абстрактные функции: f(x) и F(x)
        abstract public double Y(double x);
        abstract public double IntY(double low, double hi);

        public double MidRectMethod(double low, double intStep, double stepCount)
        { // интегрирование методом трапеций
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                result += Y(x - intStep / 2) * intStep;
                x += intStep;
            }

            return result;
        }

        public double TrapeziaMethod(double low, double intStep, double stepCount) 
        { // интегрирование методом трапеций
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                result += (Y(x) + Y(x - intStep)) / 2 * intStep;
                x += intStep;
            }

            return result;
        }

        public double Simspon2Method(double low, double intStep, double stepCount)
        { // метод для интегрирования методом Симпсона 3/8
            double result = 0, x = low;

            for (int i = 1; i < stepCount; i++)
            {
                /* 
                    для удобства числитель разбит на 
                    три дополнительные переменные
                */
                double a = Y(x - intStep);
                double b = 3 * Y((2 * (x - intStep) + x) / 3);
                double c = 3 * Y((x - intStep + 2 * x) / 3);

                result += (a + b + c + Y(x)) / 8 * intStep;
                x += intStep;
            }

            return result;
        }
    }
}