using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{    
    /// <summary>
    /// Problem Description
    /// Given a sequence A of size N, find the length of the longest increasing subsequence/
    /// Example
    /// Input  : {5, 8, 3, 7, 9, 1}
    /// Output : 3 =>  (5,8,9} /{3, 7, 9}/{5,7,9}
    /// </summary>
    class LongestIncreasingSubsequence
    {
        public static int LongestIncreasingSubSequenceLengthBruteForce(int[] A)
        {
            int n = A.Length;
            int maxLength = int.MinValue;
            for (int i=0; i<n-1; ++i)
            {
                int subsequenceLength = 1;
                int j = i + 1;
                int startingElement = A[i];
                while (j < n)
                {
                    if (A[j] > startingElement)
                    {
                        subsequenceLength++;
                        startingElement = A[j];
                    }
                    j++;
                }
                if (subsequenceLength > maxLength)
                {
                    maxLength = subsequenceLength;
                }
            }
            return maxLength;
        }
    }
}
