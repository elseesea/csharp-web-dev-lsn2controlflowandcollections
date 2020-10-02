using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> lstNumbers = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610};
            Console.WriteLine(ListPractice.GetSumEven(lstNumbers));

            string aString = "I would not, could not, in a box. I would not, could not with a fox. I will not eat them in a house.I will not eat them with a mouse.";
            List<string> result = aString.Split(" ").ToList();
            List<string> lstString = new List<string> { "hello", "good", "thief", "steal", "bye", "time", "remote", "power" };
            Console.WriteLine("Search for words of what length?");
            string userInput = Console.ReadLine();
            ListPractice.Print5LetterWords(result, int.Parse(userInput));
        }
    }
}
