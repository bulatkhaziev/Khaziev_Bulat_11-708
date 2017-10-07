/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание:
 *      -Рисует равнобедренный треугольник высотой H.
*/

using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int 
                triangleHeight = Convert.ToInt32(Console.ReadLine()),
                i,
                j,
                margin,
                widthBlock,
                maxWidth = triangleHeight * 2 - 1;

            for(i = 1; i <= triangleHeight; i++)
            {
                margin = (maxWidth - (i * 2 - 1)) / 2;
                widthBlock = maxWidth - margin * 2;

                for (j = 0; j < margin; j++)
                    Console.Write(" ");
                
                for (j = 0; j < widthBlock; j++)
                    Console.Write("^");

                for (j = 0; j < margin; j++)
                    Console.Write(" ");

                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}