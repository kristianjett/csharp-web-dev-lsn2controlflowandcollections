using System;

namespace ArrayExercises
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] practiceArray = { 1, 1, 2, 3, 5, 8 };

            foreach (int n in practiceArray)
            {
                if (n%2 != 0)
                {
                    Console.WriteLine(n);
                }
                
            }
        }
    }
}
