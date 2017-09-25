using System;

namespace ConsoleApp
{
    class SumOfMultipleNumbers
    {
        public static void Main(string[] args)
        {
            int sumOfNumbers = 0, 
                maxValue = 1000;
            
            for(int i = 0; i < maxValue; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) // если число кратно 3 или 5 без остатка, то складываем к sumOfNumbers.
                    sumOfNumbers += i;
            }

            Console.WriteLine("Сумма чисел кратных 3 или 5 до {0}: {1}", maxValue, sumOfNumbers);
            Console.ReadKey();
        }
    }
}