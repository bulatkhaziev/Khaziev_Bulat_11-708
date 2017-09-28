/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание программы:
 *  -Данная программа проверяет шахматный зод на корректность.
 *      
 *      Доступные фигуры:
 *          -Слов
 *          -Конь
 *          -Ладья
 *          -Ферзь
 *          -Король
 */

using System;

namespace ConsoleApp
{
    class CheckIsCorrectMove
    {
        public enum Figures
        {
            Bishop,
            Knight,
            Rock,
            Queen,
            King
        };

        public static bool IsMoveCorrect(int figure, string startField, string finalField)
        {
            int
                diffX = Math.Abs(startField[0] - finalField[0]),
                diffY = Math.Abs(startField[1] - finalField[1]);
            
            switch (figure)
            {
                case (int)Figures.Bishop:
                    return diffX == diffY ? true : false;
                case (int)Figures.Knight:
                    return Math.Abs(diffX - diffY) == 1 ? true : false;
                case (int)Figures.Rock:
                    return Math.Min(diffX, diffY) == 0 && Math.Max(diffX, diffY) != 0 ? true : false;
                case (int)Figures.Queen:
                    return (diffX == diffY || Math.Min(diffX, diffY) == 0 && Math.Max(diffX, diffY) != 0) ? true : false;
                case (int)Figures.King:
                    return (diffX == diffY || Math.Abs(diffX + diffY) == 1) ? true : false;
            }
            return false;
        }

        public static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split(' '); // Фигура начальная_позиция конечная_позиция

            int
                figure = Convert.ToInt32(parameters[0]);

            string
                startField = parameters[1],
                finalField = parameters[2];

            Console.WriteLine("This move is: {0}", IsMoveCorrect(figure, startField, finalField) ? "Correct" : "Not correct");
            Console.ReadKey();
        }
    }
}