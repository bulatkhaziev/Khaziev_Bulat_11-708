using System;

namespace ConsoleApp
{
    class ConvertNumToHex
    {
        public static void Main(string[] args)
        {
            int number = 3124124; // Число, которое нужно перевести.
            string hexNumber = Convert.ToString(number, 16); // Перевод в 16-ти ричную систему исчисления.

            Console.WriteLine(hexNumber);
            Console.ReadKey();
        }
    }
}