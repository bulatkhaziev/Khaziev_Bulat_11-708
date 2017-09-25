using System;

namespace ConsoleApp
{
    class LongestSequenceOfEvenNumbers
    {
        public static void Main(string[] args)
        {
            int longestSequenceCount = 0,
                currentSequenceCount = 0,
                tempNumber = 0;

            for (;;)
            {
                tempNumber = Convert.ToInt32(Console.ReadLine());

                if(tempNumber == 0)
                {
                    Console.WriteLine("Максимальное количество последовательных положительных чисел: {0}", longestSequenceCount);
                    Console.ReadKey();
                    break;
                }

                if (tempNumber % 2 == 0)
                {
                    currentSequenceCount += 1;

                    if (currentSequenceCount > longestSequenceCount)
                        longestSequenceCount = currentSequenceCount;
                }
                else currentSequenceCount = 0;
            }
        }
    }
}