using Algorithms.Amazon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 2, 3, 4, 5, 10, 20 };
            //Console.WriteLine(TripletCount.countTriplets(A, A.Length));
            // Console.WriteLine(SubArraySum.printSubArraySumOptimized(A, A.Length, 33).ToString());

            //int[] A = { -1 ,-2, -3, -2, 5 };
            // Console.WriteLine(Kadane.maximumSubArraySum(A, A.Length));
            //Console.WriteLine(Kadane.maximumSubArraySumBruteForce(A, A.Length));
            //Console.WriteLine(MaximumSubArrayProduct.maxSubArrayProduct(A, A.Length));

            /*int[] A = { 1, 2, 3, 5 };

            Console.WriteLine(MissingNumberInArray.MissingNumberUsingXOR(A));
            Console.WriteLine(MissingNumberInArray.MissingNumberUsingSum(A));
            */
            int[] A = {0,8,4,12,2,10,6,14,1,9,5,13,3,11,7};
            Console.WriteLine(LongestIncreasingSubsequence.LongestIncreasingSubSequenceLengthBruteForce(A));

            Console.ReadKey();
        }
    }
}
