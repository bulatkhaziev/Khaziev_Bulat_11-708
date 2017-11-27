using System;

namespace ConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
        	double epsilon = Convert.ToDouble(Console.ReadLine());
			double[] data = GetApproximationValueAndCountOfSteps(epsilon);
			
        	Console.WriteLine("Approximation value of Math.PI: {0}\nCount of steps: {1}", data[0], data[1]);
        }
		
        public static double GetApproximationValueAndCountOfSteps(double epsilon)
        {
			int k = 0;
			double result = 0;
			double currentElement = 0;

			do
			{
				currentElement = GetRowSequenceElement(k++);
				result += currentElement;
			}
			while(Math.Abs(currentElement) > epsilon);

			return new[] {result, k};
        }
      	
        public static double GetRowSequenceElement(int k)
        {
			return (double)(4 * (k % 2 == 0 ? 1 : -1)) / (2 * k + 1);
        }
    }
}