using System;
using Solver;

namespace PS2_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            double
                x = double.Parse(Console.ReadLine()),
                epsilon = double.Parse(Console.ReadLine());

            double[] data = EquationSolver.GetSumAndCountOfSteps(a, x, epsilon);

            Console.WriteLine("Номер шага: {0}\nСумма ряда: {1}", data[0], data[1]);
        }
    }
}
