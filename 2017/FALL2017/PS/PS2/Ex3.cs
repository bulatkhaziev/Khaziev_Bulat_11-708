using System;

namespace ConsoleApp6
{
    class Program
    {
        public static void Main(string[] args)
        {
            double epsilon = double.Parse(Console.ReadLine());
            double[] data = GetApproximentValueAndCountOfSteps(epsilon);

            Console.WriteLine("Approximent value of Catalan constant: {0}\nCount of steps: {1}", data[0], data[1]);
        }

        public static double[] GetApproximentValueAndCountOfSteps(double epsilon)
        {
            int countOfSteps = 0;
            double currentElement = 0;
            double approximentValue = 0;

            do
            {
				// ---check--- тоже неоптимальное решение
                currentElement = GetRowSequenceElement(countOfSteps++);
                approximentValue += currentElement;
            }
            while (Math.Abs(currentElement) > epsilon);

            return new[] { approximentValue, countOfSteps };
        }

        public static double GetRowSequenceElement(int n)
        {
            return (double) (n % 2 == 0 ? 1 : -1) / GetPow(2 * n + 1, 2);
        }

        public static double GetPow(double number, int power)
        {
            if (power == 0) return 1;
            if (power == 1) return number;

            return number * GetPow(number, power - 1);
        }
    }
}
