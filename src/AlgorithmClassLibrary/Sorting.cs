using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary
{
    public class Sorting
    {
        /// <summary>
        /// Returns largest int provided int array. 
        /// </summary>
        /// <param name="intArray">int array to test</param>
        /// <returns>largest int in array</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// </remarks>
        public static int GetLargestIntFromArray(int[] intArray)
        {
            int largest = intArray[0];

            for (int i = 1; i < intArray.Length; i++)
            {
                if (intArray[i] > largest)
                {
                    largest = intArray[i];
                }
            }

            return largest;
        }
    }
}
