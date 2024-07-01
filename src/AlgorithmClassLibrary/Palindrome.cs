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
        /// * Time Complexity: O(n) - Linear, pointers start n away from each other and get closer with each loop iteration
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// More about using two pointers and palindromes here:
        /// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/
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
