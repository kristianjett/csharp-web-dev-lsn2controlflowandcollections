using System;
using System.Collections.Generic;

namespace ListExercises
{
    class ListClass
    {
        static void Main(string[] args)
        {
            List<int> practiceList = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(evenNumberSum(practiceList));
        }

        private static int evenNumberSum(List<int> list)
        {
            int sum = 0;

            foreach (int n in list)
            {
                if (n%2 == 0)
                {
                    sum += n;
                }
            }
            return sum;
        }
    }
}
