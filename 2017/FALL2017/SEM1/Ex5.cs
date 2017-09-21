/*
 * Автор программы - Хазиев Булат 11-708.
 * 
 * Что делает программа:
 *  - Программа выводит високосные года на промежутке от [a;b]
 */

using System;

namespace ConsoleApp
{
    class IsYearLeap
    {
        public static void Main(string[] args)
        {
            int startyear = 1899,
                endyear = 1913,
                diff = endyear - startyear,
                years = (endyear - startyear) / 4;
                years = (years % 4 == 0) ? (years + 1) : years;

            Console.WriteLine(years);
            Console.ReadKey();
        }
    }
} 