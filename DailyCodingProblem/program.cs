using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem
{
    class program
    {
        public static void Main(string[] args)
        {
           /* int[] input = { 10, 15, 3, 7 };
            Console.WriteLine(August_31_2019.doesPairWithSumExist(input, 100));
            Console.ReadKey();
            */

            int[] input = { 1, 2, 3, 4, 5 };
            PrintArray(Sep_1_2019.ProductOfAllNumbersOtherThanCurrent(input));
            Console.ReadKey();
        }

        public static void PrintArray(int[] input)
        {
            foreach (int e in input)
            {
                Console.WriteLine(e);
            }
        }
    }
}
