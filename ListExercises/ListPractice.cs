using System;
using System.Collections.Generic;
using System.Text;

namespace ListExercises
{
    class ListPractice
    {
        public static int GetSumEven(List<int> lstInts)
        {
            int sumOfEvens = 0;

            foreach (int anInt in lstInts)
            {
                if (anInt%2 == 0)
                {
                    sumOfEvens += anInt;
                }
            }
            return sumOfEvens;
        }

        public static void Print5LetterWords(List<string> lstWords, int searchLength = 5)
        {
            foreach (string aWord in lstWords)
            {
                if (aWord.Length == searchLength)
                {
                    Console.WriteLine(aWord);
                }
            }
        }
    }
}
