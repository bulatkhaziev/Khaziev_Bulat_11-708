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

	    // ---check--- Плохая практика, использовать for без параметров и условий, лучше использовать while
            for (;;) 
            {
                tempNumber = Convert.ToInt32(Console.ReadLine());

                if(tempNumber == 0)
                {
 	 	    // не положительных, а четных же
                    Console.WriteLine("Максимальное количество последовательных положительных чисел: {0}", longestSequenceCount);
                    Console.ReadKey();
                    break;
                }

                if (tempNumber % 2 == 0)
                {
                    currentSequenceCount += 1;

		    // грамотнее это условие перенести в else, чтобы проверку осуществлять единственный раз, а не на каждой итерации цикла
		    // ну и тогда после цикла надо добавить дополнительную проверку, не получилась ли самая длинна последоватльеость
                    if (currentSequenceCount > longestSequenceCount)
                        longestSequenceCount = currentSequenceCount;
                }
                else currentSequenceCount = 0;
            }
        }
    }
}
