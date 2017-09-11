/*
 * Автор программы - Хазиев Булат 11-708.
 * 
 * Что делает программа:
 *  - Программа переворачивает 3-х значное число задом наперед.
 */

using System;

namespace ConsoleApp
{
    class SwapNumbersProgram
    {
        public static void Main(string[] args)
        {
            int number = 321,   // Исходное число
                firstChar = number / 100,
                secondChar = number % 100 / 10,
                thirdChar = number % 100 % 10,
                resultNumber = thirdChar * 100 + secondChar * 10 + firstChar;

            Console.WriteLine(resultNumber);
            Console.ReadKey();
        }
    }
} 