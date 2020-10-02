using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Lists!");
            List<int> lstNumbers = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};
            Console.WriteLine(ListPractice.GetSumEven(lstNumbers));

            List<string> lstString = new List<string> { "hello", "good", "thief", "steal", "bye", "time", "remote", "power" };
            Console.WriteLine("Search for words of what length?");
            string userInput = Console.ReadLine();
            ListPractice.Print5LetterWords(lstString, int.Parse(userInput));
        }
    }
}
