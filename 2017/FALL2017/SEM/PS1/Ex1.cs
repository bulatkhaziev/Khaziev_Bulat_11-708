/*
 * Автор программы - Хазиев Булат 11-708.
 * 
 * Что делает программа:
 *  - Программа считываем 6-ти значное число и проверяет, является ли оно "счастливым". Счастливое число - это когда сумма первых 3-х цифр равна сумме последних 3-х цифр.
 */

using System;

namespace ConsoleApp
{
    class IsTicketHappy
    {
        public static void Main(string[] args)
        {
            int ticketNumber = Convert.ToInt32(Console.ReadLine());
           
            int firstTicketPart = ticketNumber / 100000 + ticketNumber / 10000 % 10 + ticketNumber / 1000 % 100 % 10; // вычисляем сумму первых 3-х цифр.
            int secondTicketPart = ticketNumber / 100 % 1000 % 100 % 10 + ticketNumber / 10 % 10000 % 1000 % 100 % 10 + ticketNumber % 100000 % 10000 % 1000 % 100 % 10; // сумма последних 3-цифр.
            
            if (firstTicketPart == secondTicketPart)
                Console.WriteLine("Поздравляем! Билет №{0} является счастливым!", ticketNumber);
            else
                Console.WriteLine("К нашему сожалению, билет №{0} не является счастливым.", ticketNumber);
            Console.ReadKey();
        }
    }
}