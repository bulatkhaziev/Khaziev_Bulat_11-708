/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание:
 *      -Переводит число из десятичной системы исчисления в шестнадцатиричную.
*/

using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int
                inputValue = Convert.ToInt32(Console.ReadLine()), // Считывает десятичное число (int). Например: 1000
                tempValue = 0,
                countValues = 0;

            int[] resultValue = new int[inputValue.ToString().Length]; // Массив для записи итогового числа.
            string[] changedValues = new string[6] {"A", "B", "C", "D", "E", "F"};

            while(inputValue > 1)
            {
                resultValue[countValues++] = inputValue - inputValue / 16 * 16; // Высчитываем остаток при делении.
                inputValue /= 16;
            }

            for(int i = 1; i < resultValue.Length; i++)
            {
                tempValue = resultValue[resultValue.Length - 1 - i];

                switch (tempValue >= 10)
                {
                    case true: Console.Write(changedValues[tempValue - 10]); break;
                    case false: Console.Write(tempValue); break;
                }
            }
            Console.ReadKey();
        }
    }
}
