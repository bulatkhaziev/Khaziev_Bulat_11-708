/*
 * Автор программы - Хазиев Булат. 11-708
 * 
 * Описание программы:
 *  Считает угол между часовой и минутной стрелкой.
 */

using System;

namespace CalculateAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            int 
                hours = Convert.ToInt32(Console.ReadLine()),
                angle = (hours * 30) % 360;
            
            Console.WriteLine("Угол: {0} градусов", angle);
            Console.ReadKey();
        }
    }
}
