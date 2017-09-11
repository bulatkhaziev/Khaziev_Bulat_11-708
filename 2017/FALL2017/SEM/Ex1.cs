/*
 * Автор программы - Хазиев Булат 11-708.
 * 
 * Что делает программа:
 *  - Программа меняет местами значения в перменных без использования новой переменной.
 */

using System;

namespace ConsoleApp
{
    class SwapNumbersProgram
    {
        public static void Main(string[] args)
        {
            int firstNum = 10;
            int secondNum = 5;

            secondNum = secondNum - firstNum;
            firstNum = secondNum + firstNum;
            secondNum = firstNum - secondNum;

            Console.WriteLine("Значение 1-ой переменной: {0}. Значение второй переменной: {1}", firstNum, secondNum);
			
            Console.ReadKey();
        }
    }
} 