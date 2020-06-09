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
            Console.WriteLine("Hello!");

            Console.Write("lowerBound = ");
            lowerBound = Convert.ToDouble(Console.ReadLine());
            Console.Write("upperBound = ");
            upperBound = Convert.ToDouble(Console.ReadLine());
            Console.Write("stepCount = ");
            stepCount = Convert.ToDouble(Console.ReadLine());

            function = new Function1();
            double intStep = (upperBound - lowerBound) / stepCount;

            var midRectResult = function.MidRectMethod(lowerBound, intStep, stepCount);
            var trapeziaResult = function.TrapeziaMethod(lowerBound, intStep, stepCount);
            var analyticResult = function.IntY(lowerBound, upperBound);

            Console.WriteLine("mid rect: {0:f8}", midRectResult);
            Console.WriteLine("trapezia: {0:f8}", trapeziaResult);
            Console.WriteLine("analytic: {0:f8}", analyticResult);
        }
    }
}
