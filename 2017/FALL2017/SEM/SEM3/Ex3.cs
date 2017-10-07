/*
 * Автор программы: Хазиев Булат 11-708
 * 
 * Описание:
 * Дан номер трамвайного билета, в котором суммы первых трёх цифр и последних трёх цифр отличаются на 1 (но не сказано, в какую сторону). 
 * Программа вычисляет, правда ли, что предыдущий или следующий билет является счастливым.
*/

using System;

namespace ConsoleApp
{
    class IsTicketHappines
    {
        public static void Main(string[] args)
        {
            int
                ticketNumber = Convert.ToInt32(Console.ReadLine()),
                firstTicketPart = ticketNumber / 100000 + ticketNumber / 10000 % 10 + ticketNumber / 1000 % 100 % 10,
                secondTicketPartDecrement = (ticketNumber - 1) / 100 % 1000 % 100 % 10 + (ticketNumber - 1) / 10 % 10000 % 1000 % 100 % 10 + (ticketNumber - 1) % 100000 % 10000 % 1000 % 100 % 10,
                secondTicketPartIncrement = (ticketNumber + 1) / 100 % 1000 % 100 % 10 + (ticketNumber + 1) / 10 % 10000 % 1000 % 100 % 10 + (ticketNumber + 1) % 100000 % 10000 % 1000 % 100 % 10;

            Console.WriteLine("Предыдущий билет является: {0}", (firstTicketPart == secondTicketPartDecrement) ? "Счастливым" : "Не счастивым");
            Console.WriteLine("Следующий билет является: {0}", (firstTicketPart == secondTicketPartIncrement) ? "Счастливым" : "Не счастливым");

            Console.ReadKey();
        }
    }
}

1. транспортная карта - 750р(метро) 920р(автобус)
2. интернет - 250р
3. линзы - 500р
4. хоз.товары - 200р
------
= 1700р.
