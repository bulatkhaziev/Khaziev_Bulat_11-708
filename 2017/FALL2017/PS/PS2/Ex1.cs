using System;

namespace ConsoleApp6
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            double
                x = double.Parse(Console.ReadLine()),
                epsilon = double.Parse(Console.ReadLine());

            double[] data = GetSumAndCountOfSteps(a, x, epsilon);

            Console.WriteLine("Количество шагов: {0}\nСумма ряда: {1}", data[0], data[1]);
        }

        public static double[] GetSumAndCountOfSteps(int a, double x, double epsilon)
        {
            int k = 0;
            double sumOfRow = 0;
            double currentElement = 0;
            
            do
            {
                sumOfRow += GetRowSequenceSum(a, k, x);
                currentElement = GetRowSequenceSum(a, k, x);

                k++;
            }
            while (currentElement > epsilon);

            return new[] { (double)k - 1, sumOfRow };
        }

        public static double GetRowSequenceSum(int a, int k, double x)
        {
            if (k < 0)
                return 0;

            double
                numerator = Math.Pow(x, k),
                denominator = GetFactorial(k);

            for (int i = 0; i < k; i++)
            {
                numerator *= (a - i);
            }

            return (numerator / denominator);
        }

        public static double GetFactorial(int number)
        {
            if (number == 0) return 1;
            if (number == 1) return number;

            return number * GetFactorial(number - 1);
        }

        public static double GetPow(double number, int power)
        {
            if (power == 0) return 1;
            if (power == 1) return number;

            return number * GetPow(number, power - 1);
        }
    }
}
