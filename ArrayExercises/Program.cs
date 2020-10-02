using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using for loop");
            for (int i=0; i<ArrayPractice.intArry.Length; i++)
            {
                Console.WriteLine(ArrayPractice.intArry[i]);
            }

            Console.WriteLine("Using foreach loop");
            foreach (int anInt in ArrayPractice.intArry)
            {
                Console.WriteLine(anInt);
            }

            Console.WriteLine("Using foreach loop, odd numbers only");
            foreach (int anInt in ArrayPractice.intArry)
            {
                if (anInt%2 != 0)
                {
                    Console.WriteLine(anInt);
                }
            }
        }
    }
}
