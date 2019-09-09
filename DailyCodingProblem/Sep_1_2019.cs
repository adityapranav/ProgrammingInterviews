using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original 
  array except the one at i.
  
  For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. 
  If our input was [3, 2, 1], the expected output would be [2, 3, 6].
  
  Follow-up: what if you can't use division? 
 */
namespace DailyCodingProblem
{
    class Sep_1_2019
    {
        public static int[] ProductOfAllNumbersOtherThanCurrent(int[] input)
        {
            if (input.Length < 2)
            {
                return null;
            }
            int[] productBeforeCurrentElement = new int[input.Length];
            int[] productAfterCurrentElement = new int[input.Length];

            int[] result = new int[input.Length];

            productBeforeCurrentElement[0] = 1;
            for (int i=1; i<input.Length; ++i)
            {
                productBeforeCurrentElement[i] = productBeforeCurrentElement[i - 1] * input[i - 1];
            }

            productAfterCurrentElement[input.Length - 1] = 1;

            for (int i=input.Length-2; i >= 0; --i)
            {
                productAfterCurrentElement[i] = productAfterCurrentElement[i + 1] * input[i + 1];
            }

            for(int i=0; i< input.Length; ++i)
            {
                result[i] = productBeforeCurrentElement[i] * productAfterCurrentElement[i];
            }

            return result;
        }
    }
}
