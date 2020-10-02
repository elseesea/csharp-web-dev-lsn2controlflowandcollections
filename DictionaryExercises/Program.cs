using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();

            //List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;
            int newStudentID;
            string input;


            // Get student names
            do
            {
                Console.WriteLine("Enter a student (or ENTER to finish):");
                input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {

                    Console.WriteLine("Enter student ID:");
                    input = Console.ReadLine();
                    newStudentID = int.Parse(input);
                    students.Add(newStudent, newStudentID);

                }

            } while (!Equals(newStudent, ""));

/*
            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                input = Console.ReadLine();
                double grade = Double.Parse(input);
                grades.Add(grade);
            }
*/

            // Print class roster
            Console.WriteLine("\nClass roster:");
            double sum = 0.0;

            foreach (KeyValuePair<string, int> student in students)
            {
                    Console.WriteLine(student.Key + " (" + student.Value + ")");
            }
        }
    }
}
