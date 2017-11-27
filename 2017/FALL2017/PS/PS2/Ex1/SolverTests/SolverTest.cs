using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Solver.Tests
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void FactorialTest()
        {
            var numbers =  new[] { 1, 2, 3, 4, 5 };
            var factorials = new[] { 1, 2, 6, 24, 120 };

            for (int i = 0; i < numbers.Length; i++)
                Assert.AreEqual(factorials[i], EquationSolver.GetFactorial(numbers[i]));
        }
        
        [TestMethod]
        public void StepsCountTest()
        {
            int a = 30;
            double x = 0.1;
            double epsilon = 0.001;

            Assert.AreEqual(10, EquationSolver.GetSumAndCountOfSteps(a, x, epsilon)[0]);
        }

        [TestMethod]
        public void RowSummaryTest()
        {
            int a = 2;
            double x = 0.1;
            double epsilon = 0.001;

            Assert.AreEqual(1.21, EquationSolver.GetSumAndCountOfSteps(a, x, epsilon)[1]);
        }

        [TestMethod]
        public void RowElementContainsTest()
        {
            int a = 2;
            double x = 0.1;

            Assert.AreEqual(0.2, EquationSolver.GetRowSequenceElement(a, 1, x));
        }
    }
}
