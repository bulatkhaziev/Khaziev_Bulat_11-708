using System;

namespace ConsoleApp
{
    class SwapNumbersProgram
    {
        public static void Main(string[] args)
        {
            int[] ticketNumbers = { 123321, 122322, 453512 }; // Номера билетов для анализа.

            for(int i = 0; i < ticketNumbers.Length; i++)
            {
                IsThisTicketHappy(ticketNumbers[i]);
            }
            Console.ReadKey();
        }

        static void IsThisTicketHappy(int ticketNumber)
        {
            string strTicketNumber = ticketNumber.ToString();
            int ticketNumberLength = strTicketNumber.Length,
                firstTicketPartSum = 0,
                secondTicketPartSum = 0;

            // Деление номера билета на две части.
            string firstTicketPart = strTicketNumber.Substring(0, ticketNumberLength / 2), 
                   secondTicketPart = strTicketNumber.Substring(ticketNumberLength / 2, ticketNumberLength / 2);

            // Сложение цифр первой части билета.
            for(int i = 0; i < firstTicketPart.Length; i++)
                firstTicketPartSum += firstTicketPart[i];

            // Сложение цифр второй части билета.
            for (int i = 0; i < secondTicketPart.Length; i++)
                secondTicketPartSum += secondTicketPart[i];

            // Вывод результата анализа.
            if (firstTicketPartSum == secondTicketPartSum)
                Console.WriteLine("Наши поздравления! Билет №{0} является счастливым!", ticketNumber);
            else
                Console.WriteLine("К нашему сожалению, билет №{0} не является счастливым.", ticketNumber);
        }
    }
}