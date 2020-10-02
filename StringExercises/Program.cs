using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Strings!");
            string[] splitStr = StringPractice.aString.Split(" ");
            Console.WriteLine(string.Join(",", splitStr));

            string[] anotherSplitStr = StringPractice.aString.Split(".");
            Console.WriteLine(string.Join(",", anotherSplitStr));

        }
    }
}
