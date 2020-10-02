using System;
using System.Linq;

namespace StringExercises
{
    class String
    {
        static void Main(string[] args)
        {
            string practiceString = "I would not, could not, in a box. I would not, could not with a fox. " +
                "I will not eat them in a house. I will not eat them with a mouse.";

            string[] practicePushArray = practiceString.Split(".");

            //foreach (string word in practicePushArray)
            //{
            //    Console.WriteLine(word);
            //}

            Console.WriteLine(string.Join(".", practicePushArray));

        }
    }
}
