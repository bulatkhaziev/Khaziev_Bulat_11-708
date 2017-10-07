/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание:
 *      -Нахождение всех простых чисел от 1 до 10000.
*/

using System;

namespace ConsoleApp
{
    class Program
    {
        public const int MAX_VALUE = 10000;

        public static void Main(string[] args)
        {
            for(int i = 2; i < MAX_VALUE; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    continue;

                Console.Write("{0} ", i);
            }
            Console.ReadKey();
        }
    }
}
