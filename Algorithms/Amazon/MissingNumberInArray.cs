using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    class MissingNumberInArray
    {
        public static int MissingNumberUsingXOR(int[] A)
        {
            int xorResult1 = 1;
            for(int i=2; i<= A.Length+1; ++i)
            {
                xorResult1 = (xorResult1 ^ i);
            }
            int xorResult2 = A[0];
            for (int i=1; i< A.Length; ++i)
            {
                xorResult2 = xorResult2 ^ A[i];
            }
            return xorResult1 ^ xorResult2;
        }

        public static int MissingNumberUsingSum(int[] A)
        {
            int sum = 1;
            for (int i=2; i<=A.Length+1; i++)
            {
                sum += i;
                sum -= A[i - 2];
            }
            return sum;
        }
    }
}
