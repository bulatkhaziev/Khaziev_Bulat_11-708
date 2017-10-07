/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание:
 *      -Нахождение всех простых чисел от 1 до 10000 (MAX_VALUE).
*/

using System;

namespace ConsoleApp
{
    class Program
    {
        public const int MAX_VALUE = 10000;

        public static void Main(string[] args)
        {
            int[] filteredNumbers = new int[MAX_VALUE / 2]; // Легальное уменьшение размера массива
            int
                i,
                count = 0,
                targetValue = Convert.ToInt32(Console.ReadLine()); // Считываем индекс искомого простого числа. Отсчет начинается с 0.

            for(i = 2; i < MAX_VALUE; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    continue;

                filteredNumbers[count++] = i;
            }

            Console.WriteLine(filteredNumbers[targetValue]);
            Console.ReadKey();
        }
    }
}
