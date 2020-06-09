using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_integration
{
    class Program
    {
        public static IntegrationMethods function;

        static void Main(string[] args)
        {
            double lowerBound, upperBound, stepCount;

            Console.Title = "Проект по модулю, часть 2, вариант 8. Корнев Дмитрий, ЭУ-193631";
            Console.WriteLine("Приближённое вычисление интегралов заданных функций");
            
            while (true)
            {
                Console.Write("\nМеню\n" +
                            "1. y = 8 / (5 + 2*x^2)\n" +
                            "2. y = x^2 / (x + 8)^(1/3)\n" +
                            "3. Выход\n\n");
                
                bool inputFail = true;

                while (inputFail) 
                {
                    Console.Write("Выберите пункт: ");
                    byte choice = Convert.ToByte(Console.ReadLine());

                    switch (choice) 
                    {
                        case 1:
                            function = new Function1();
                            inputFail = false;
                            break;
                        case 2:
                            function = new Function2();
                            inputFail = false;
                            break;
                        case 3:
                            inputFail = false;
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("До свидания!\n");
                            Console.ResetColor();
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный выбор.\n");
                            Console.ResetColor();
                            break;
                    }
                }

                Console.Write("\nНижняя граница = ");
                lowerBound = Convert.ToDouble(Console.ReadLine());
                Console.Write("Верхняя граница = ");
                upperBound = Convert.ToDouble(Console.ReadLine());
                Console.Write("Количество шагов = ");
                stepCount = Convert.ToDouble(Console.ReadLine());

                double intStep = (upperBound - lowerBound) / stepCount;

                var midRectsResult = function.MidRectMethod(lowerBound, intStep, stepCount);
                var trapeziaResult = function.TrapeziaMethod(lowerBound, intStep, stepCount);
                var simpson2Result = function.Simspon2Method(lowerBound, intStep, stepCount);
                var analyticResult = function.IntY(lowerBound, upperBound);

                Console.WriteLine("mid rect: {0:f8}", midRectsResult);
                Console.WriteLine("trapezia: {0:f8}", trapeziaResult);
                Console.WriteLine("simpson2: {0:f8}", simpson2Result);
                Console.WriteLine("analytic: {0:f8}", analyticResult);
            }
        }
    }
}
