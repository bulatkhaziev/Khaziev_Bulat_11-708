using System;

namespace ConsoleApp
{
    class MinNumsOfSquaresOfNatNums
    {
        public static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine()),
                tempnumber = number,
                minnums = 0,
                pownednum = 0;

            while (tempnumber != 0)
            {
                pownednum = (int)Math.Sqrt(tempnumber); // Находим корень максимального близкого числа к начальному.
                tempnumber -= (int)Math.Pow(pownednum, 2); // Вычитаем его.
                minnums += 1;
            }

            Console.WriteLine(minnums);
            Console.ReadKey();
        }
    }
}