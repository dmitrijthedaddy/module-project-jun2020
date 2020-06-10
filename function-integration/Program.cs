using System;

namespace function_integration
{
    class Program
    {
        public static IntegrationMethods function;

        static void Main(string[] args)
        {
            double lowerBound, upperBound, stepCount;
            byte choice = 0;

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
                    choice = Convert.ToByte(Console.ReadLine());

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

                Console.WriteLine("Результаты численного интегрирования\n" +
                                  "--------------------------------------------------------------------\n" +
                                  $"Функция {choice}. {function.FuncSpelling()}; " + 
                                  $"шаг {intStep:f2}; a={lowerBound}; b={upperBound}; s = {analyticResult:f8}");
                Console.WriteLine($"Метод средних прямоугольников | {midRectsResult,11:f8}, " + 
                                  $"погрешность: {Math.Abs(analyticResult - midRectsResult),-11:f8}\n" +
                                  $"Метод трапеций                | {trapeziaResult,11:f8}, " +
                                  $"погрешность: {Math.Abs(analyticResult - trapeziaResult),-11:f8}\n" +
                                  $"Метод Симпсона 3/8            | {simpson2Result,11:f8}, " + 
                                  $"погрешность: {Math.Abs(analyticResult - simpson2Result),-11:f8}");
                Console.WriteLine("--------------------------------------------------------------------");
            }
        }
    }
}