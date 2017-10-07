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
                widthBlock;

            for(i = 1; i <= triangleHeight; i++)
            {
                margin = ((triangleHeight * 2 - 1) - (i * 2 - 1)) / 2;
                widthBlock = (triangleHeight * 2 - 1) - margin * 2;

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