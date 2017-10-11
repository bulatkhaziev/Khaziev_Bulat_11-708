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
                
                WriteChar(" ", margin);
                WriteChar("^", widthBlock);
                WriteChar(" ", margin);

                Console.Write("\n");
            }
            Console.ReadKey();
        }
        
        public static void WriteChar(char chr, int count)
        {
            for(int i = 0; i < count; i++)
                Console.Write(chr);
        }
    }
}
