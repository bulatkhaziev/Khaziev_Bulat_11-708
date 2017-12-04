using System;

namespace Solver
{
    public class EquationSolver
    {
        public static double[] GetSumAndCountOfSteps(int a, double x, double epsilon)
        {
            int step = 0;
            double currentElement = GetRowSequenceElement(a, step, x);
            double sumOfRow = currentElement;

            while (Math.Abs(currentElement) > epsilon)
            {
                currentElement = GetRowSequenceElement(a, ++step, x);
                sumOfRow += currentElement;
            }

            return new[] { --step, sumOfRow };
        }

        public static double GetRowSequenceElement(int a, int k, double x)
        {
            if (k < 0)
                return 0;

            double
                numerator = (double)Math.Pow(-1 + a, k) * x * Math.Pow(Math.Log(x), k),
                denominator = GetFactorial(k);
            
            return numerator / denominator;
        }

        public static double GetFactorial(int number)
        {
            if (number == 0) return 1;
            if (number == 1) return number;

            return GetFactorial(number - 1) * number;
        }
    }
}
