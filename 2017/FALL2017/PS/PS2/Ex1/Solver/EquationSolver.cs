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

            while (currentElement > epsilon)
            {
				// ---check---неоптимально пересчитывать всё с начала на каждом шаге, надо использовать предыдущие вычисленные результаты
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
                numerator = Math.Pow(x, k),
                denominator = GetFactorial(k);

            for (int i = 0; i < k; i++)
                numerator *= (a - i);

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
