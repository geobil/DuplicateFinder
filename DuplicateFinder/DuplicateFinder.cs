using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFinder
{
    public class DuplicateFinder
    {
        /// <summary>
        /// Retrieves the duplicate in a given array of n numbers that contains all numbers between 1 to n-1
        /// </summary>
        /// <param name="array">The input sequence</param>
        /// <param name="n">The length of the input sequence</param>
        /// <returns></returns>
        public int FindTheDuplicate(List<int> array, int n)
        {
            try
            {
                // Use Gauss sum to get the sum of the (1, n-1) sequence
                long gaussSum = (long)n * (n - 1) / 2;
                // Get the sum of the input sequence
                long currentSum = 0;
                foreach (int nr in array)
                    currentSum += nr;
                // The duplicate element is the difference between the 2 sums
                return (int)(currentSum - gaussSum);
            }
            catch (OutOfMemoryException)
            {
                // For test's sake try a smaller n
                return -1;
            }
        }
    }
}
