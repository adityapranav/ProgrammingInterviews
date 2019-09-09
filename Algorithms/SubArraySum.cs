using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Problem Description
    /// Given an unsorted array A of size N of non-negative integers,
    /// find a continuous sub-array which adds to a given number S.
    /// Print the start and end index of the sub-array
    /// </summary>
    class SubArraySum
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">Unsorted Array</param>
        /// <param name="N">Size of the Unsorted Array</param>
        /// <param name="S">Sum</param>
        /// <returns>start and Endindex of the subarray</returns>
        public static IndexPair printSubArraySum(int[] A, int N, int S)
        {
            for(int i=0;i<N;++i)
            {
                int sum = A[i];
                for(int j=i+1; j<N; ++j)
                {
                    if (sum == S)
                    {
                        return new IndexPair(i, j-1);
                    }
                    // the below condition is put because, we can break if we have already reached end of the array, or we got a sum 
                    // already greater than S. In both the cases, start with a different starting point i.
                    if (sum > S || j == N)
                    {
                        break;
                    }
                    sum += A[j];
                }
            }
            return new IndexPair(-1, -1);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="A">input Array</param>
        /// <param name="N">Length of the input Array</param>
        /// <param name="S">the Sum that we are looking for</param>
        /// <returns>Begin and End of the subarray with sum S</returns>
        public static IndexPair printSubArraySumOptimized(int[] A, int N, int S)
        {
            int currentSum = A[0];
            int startIndex = 0;
            for (int i = 1; i < N; ++i)
            {
                if (currentSum == S)
                {
                    return new IndexPair(startIndex, i-1);
                }
                currentSum += A[i];
                while (currentSum > S && startIndex < i)
                {
                    currentSum = currentSum - A[startIndex];
                    startIndex++;
                }
            }
            return new IndexPair(-1, -1);
        }
    }

    class IndexPair
    {
        int startIndex;
        int endIndex;

        public IndexPair(int s, int e)
        {
            this.startIndex = s;
            this.endIndex  =  e;
        }

        public override string ToString()
        {
            return "{" + this.startIndex + ", " + this.endIndex + "}";
        }
    }
}
