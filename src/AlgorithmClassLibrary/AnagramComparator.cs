using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary
{
    public class AnagramComparator
    {
        /// <summary>
        /// Compares two strings to determine if the strings are anagrams (a word, phrase, or name formed by rearranging the letters of another). 
        /// Notes:
        /// * Does not check for nulls
        /// * It is case sensentive
        /// </summary>
        /// <param name="firstString">first string to compare</param>
        /// <param name="secondString">second string to compare</param>
        /// <returns>True or False if two strings are anagrams</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// </remarks>
        public static bool AreAnagrams(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }

            char[] s1Array = firstString.ToCharArray();
            char[] s2Array = secondString.ToCharArray();

            // sort characters in each string
            Array.Sort(s1Array);
            Array.Sort(s2Array);

            // compare each character by position in arrays, return false if a non-match is found 
            for (int i = 0; i < s1Array.Length; i++)
            {
                if (s1Array[i] != s2Array[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
