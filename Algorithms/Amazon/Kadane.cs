using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    /// <summary>
    /// Problem Description
    /// Given an array arr of N integers. Find the contiguous sub-array with maximum sum.
    /// Example
    /// Input  : {-1, -2, -3, -4}
    /// Output : -1
    /// </summary>
    public class Kadane
    {
        static public int maximumSubArraySum(int[] A, int n)
        {
            int maxSum = A[0];
            int sumEndingHere = A[0];

            for (int i=1; i<n; i++)
            {
                sumEndingHere = Math.Max(sumEndingHere + A[i], A[i]);
                if (sumEndingHere > maxSum)
                {
                    maxSum = sumEndingHere;
                }
            }
            return maxSum;
        }

        static public int maximumSubArraySumBruteForce(int[] A, int n)
        {
            int maxSum = int.MinValue;
            
            for (int i=0; i<n; i++)
            {
                int sum = A[i];
                for (int j=i+1; j<n; ++j)
                {
                    sum += A[j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            return maxSum;
        }
    }
}
