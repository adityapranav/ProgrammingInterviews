using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Amazon
{
    class MaximumSubArrayProduct
    {
        public static int maxSubArrayProduct(int[] A, int n)
        {
            int maxProductEndingHere = A[0];
            int minProductEndingHere = A[0];
            int maxProduct = int.MinValue;

            for (int i=1; i<n; ++i)
            {
                if (A[i] > 0)
                {
                    maxProductEndingHere = Math.Max(maxProductEndingHere * A[i], A[i]);
                    minProductEndingHere = Math.Min(minProductEndingHere * A[i], A[i]);
                }
                else if (A[i] < 0)
                {
                    maxProductEndingHere = Math.Max(minProductEndingHere * A[i], A[i]);
                    minProductEndingHere = Math.Min(maxProductEndingHere * A[i], A[i]);
                }
                else
                {

                }
                
                if (maxProductEndingHere > maxProduct)
                {
                    maxProduct = maxProductEndingHere;
                }
            }
            return maxProduct;
        }
    }
}
