using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary
{
    public class Palindrome
    {
        /// <summary>
        /// Test if a word is a palindrome (reads the same forward and backward). 
        /// </summary>
        /// <param name="word">word to test</param>
        /// <returns>True/False if palindrome</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(log n) - Logarithmic, two characters are compared with each loop iteration
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// </remarks>
        public static bool IsPalindrome(string word)
        {
            var isPalindrome = true;
            var left = 0;
            var right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    isPalindrome = false;
                    break;
                }

                left++;
                right--;
            }

            return isPalindrome;
        }
    }
}
