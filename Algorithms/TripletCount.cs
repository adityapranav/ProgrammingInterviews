using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Problem Description
    /// Given an array of distinct integers. 
    /// The task is to count all the triplets such that sum of two elements equals the third element.
    /// Print the number of triplets.
    /// </summary>
    class TripletCount
    {
        public static int countTriplets(int[] A, int N)
        {
            int count = 0;
            for (int i=0; i<=N-3; ++i)
            {
                for (int j=i+1; j<=N-2; ++j)
                {
                    for (int k=j+1; k<=N-1; ++k)
                    {
                        if (A[i]+A[j] == A[k] || A[i]+A[k] == A[j] || A[j]+A[k] == A[i])
                        {
                            count++;
                        }
                    }
                }

            }

            return count;
        }
    }
}
