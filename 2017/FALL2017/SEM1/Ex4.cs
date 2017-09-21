/*
 * Автор программы - Хазиев Булат. 11-708
 * 
 * Описание программы:
 *  Находит количество чисел меньших N, которые имеют простые делители X или Y.
 */

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                number = Convert.ToInt32(Console.ReadLine()) - 1, // охватывает все числа, меньше number
                x = Convert.ToInt32(Console.ReadLine()),
                y = Convert.ToInt32(Console.ReadLine()),
                sum = (number / x) + (number / y) - (number / (x * y));

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
