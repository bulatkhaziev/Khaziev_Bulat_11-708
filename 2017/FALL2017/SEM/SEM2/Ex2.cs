/*
 * Автор программы - Хазиев Булат. 11-708
 * 
 * Описание программы:
 *  - Программа вычисляет угол между минутной и часовой стрелках.
 *  
 *  Входные строки:
 *      1. Кол-во часов
 *      2. Кол-во минут
 */

using System;

namespace ConsoleApp
{
    class SumOfMultipleNums
    {
        public static void Main(string[] args)
        {
            int
                hours = Convert.ToInt32(Console.ReadLine()),
                minutes = Convert.ToInt32(Console.ReadLine()),
                minuteArrowAngle = (minutes * 6) % 360,
                hourArrowAngle = (hours * 30) % 360,
                resultAngle = Math.Abs(hourArrowAngle - minuteArrowAngle);

            Console.WriteLine("Итоговый угол: {0}", resultAngle);
            Console.ReadKey();
        }
    }
}