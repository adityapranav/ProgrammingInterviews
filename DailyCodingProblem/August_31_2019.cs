using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
   For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
 */
namespace DailyCodingProblem
{
    class August_31_2019
    {
        public static bool doesPairWithSumExist(int[] input, int sum)
        {
            if (input.Length >= 2)
            {
                HashSet<int> set = new HashSet<int>();
                foreach (int element in input)
                {
                    if (set.Contains(sum-element))
                    {
                        return true;
                    }
                    set.Add(element);
                }
            }
            return false;
        }
    }
}
