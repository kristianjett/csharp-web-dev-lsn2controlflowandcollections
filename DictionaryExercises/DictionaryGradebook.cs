using System;
using System.Collections.Generic;

namespace DictionaryExercises
{
    class DictionaryGradebook
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            int newStudentID;
            string input;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            // Get student names and grades
            do
            {
                Console.WriteLine("Student ID: ");
                input = Console.ReadLine();
              
                
                if (int.TryParse(input, out newStudentID))
                {
                    newStudentID = int.Parse(input);
                }
                  

                if (!Equals(input, ""))
                {
                    Console.WriteLine("Name: ");
                    string newName = Console.ReadLine();
                    students.Add(newStudentID, newName);

                    // Read in the newline before looping back
                    Console.ReadLine();
                }

            } while (!Equals(input, ""));

            // Print class roster
            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"{student.Key}: {student.Value}");
            }
        }
    }
}
