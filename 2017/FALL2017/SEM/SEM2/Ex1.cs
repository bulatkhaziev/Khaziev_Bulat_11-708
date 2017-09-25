/*
 * Автор программы - Хазиев Булат. 11-708
 * 
 * Описание программы:
 *  -Программма находит сумму все чисел меньших 1000 и кратных 3 или 5.
 */

using System;

namespace ConsoleApp
{
    class SumOfMultipleNums
    {
        public static void Main(string[] args)
        {
            int
                sumMultipleNums = 1000 / 3 + 1000 / 5 - 1000 / (3 * 5);

            Console.WriteLine("Сумма чисел: {0}", sumMultipleNums);
            Console.ReadKey();
        }
    }
} 