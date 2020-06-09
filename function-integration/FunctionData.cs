using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace function_integration
{
    public static class Funcs
    {
        public static double Function1(double x)
        {
            return 8 / (5 + 2 * x * x);
        }

        public static double Function2(double x)
        {
            return x * x / Math.Pow(x + 8, 1 / 3);
        }
    }

    public static class FuncInts
    {
        public static double FunctionInt1(double x)
        {
            return 8 * Math.Atan(Math.Sqrt(2) * x / Math.Sqrt(5)) / Math.Sqrt(10);
        }

        public static double FunctionInt2(double x)
        {
            return Math.Pow(x + 8, 2 / 3) * (15 * x * x - 144 * x + 1728) / 40;
        }
    }

    public class Function1 : IntegrationMethods
    {
        public override double Y(double x)
        {
            return Funcs.Function1(x);
        }

        public override double IntY(double low, double hi)
        {
            return FuncInts.FunctionInt1(hi) - FuncInts.FunctionInt1(low);
        }
    }

    public class Function2 : IntegrationMethods
    {
        public override double Y(double x)
        {
            return Funcs.Function2(x);
        }

        public override double IntY(double low, double hi)
        {
            return FuncInts.FunctionInt2(hi) - FuncInts.FunctionInt2(low);
        }
    }
}
