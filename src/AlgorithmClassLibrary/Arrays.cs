using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgorithmClassLibrary
{
    public class Arrays
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

        /// <summary>
        /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        /// 
        /// Note:
        /// The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
        /// To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, 
        /// and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        /// </summary>
        /// <param name="nums1">first int array, will contain extra elements to hold numbs 2 data</param>
        /// <param name="nums2">second int array</param>
        /// <param name="m">Number of elements in nums1 with values, remainer are populated with zeros</param>
        /// <param name="n">Number of elements in nums2</param>
        /// <returns>void, the result is retured by updating nums1</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// See for more detail:
        /// https://leetcode.com/problems/merge-sorted-array/
        /// </remarks>
        public static void MergeTwoIntArrays(int[] nums1, int[] nums2, int m, int n)
        {
            //// add nums2 elements at end of nums1
            //for (int i = 0; i < n; i++)
            //{
            //    if (m > 0)
            //    { 
            //        nums1[m + i] = nums2[i];
            //    }
            //}

            //// sort array, loop up to 2nd last element (the inner compare will compare last element)
            //for (int i =0; i < nums1.Length -1; i++)
            //{
            //    if (nums1[i] > nums1[i + 1])
            //    { 
            //        var temp = nums1[i + 1];
            //        nums1[i + 1] = nums1[i];
            //        nums1[i] = temp;
            //    }
            //}

            var nums1Index = m - 1;
            var nums2Index = n - 1;
            var insertIndex = (m + n) - 1;

            while (nums1Index >= 0 && nums2Index >= 0)
            {
                if (nums1[nums1Index] > nums2[nums2Index])
                {
                    nums1[insertIndex] = nums1[nums1Index];
                    nums1Index--;
                }
                else
                {
                    nums1[insertIndex] = nums2[nums2Index];
                    nums2Index--;
                }
                insertIndex--;
            }

            // fill nums1 with leftover nums2 elements
            while (nums2Index > 0)
            {
                nums1[insertIndex] = nums2[nums2Index];
                nums2Index--;
                insertIndex--;
            }
        }


        /// <summary>
        /// Given a sorted array of unique integers and a target integer, return true if there exists a pair of numbers that sum to target, false otherwise. 
        /// </summary>
        /// <param name="intArray">Int array of values</param>
        /// <param name="target">the target of two values</param>
        /// <returns>True or false if two pairs of int in the array sum to the the target.</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// See for more detail:
        /// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/
        /// </remarks>
        public static bool SortedArrayPairsSumTarget(int[] intArray, int target)
        {
            var result = false;
            var leftIndex = 0;
            var rightIndex = intArray.Length - 1;
            int sum;

            while (leftIndex < rightIndex)
            {
                sum = intArray[leftIndex] + intArray[rightIndex];
                if (sum == target)
                {
                    result = true;
                    break;
                }
                else if (sum > target)
                {
                    rightIndex--;
                }
                else
                {
                    leftIndex++;
                }

                if (result) break;
            }

            return result;
        }

        /// <summary>
        /// Given two sorted integer arrays arr1 and arr2, return a new array that combines both of them and is also sorted.
        /// </summary>
        /// <param name="array1">First sorted int array</param>
        /// <param name="array2">Second sorted int array</param>
        /// <returns>A sorted int array that combines the two provided arrays</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// The trivial approach would be to first combine both input arrays and then perform a sort. This has a cost of lineartimic time complexity O(n log n) because of the cost of sorting.
        /// 
        /// See for more detail:
        /// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/
        /// </remarks>
        public static int[] CombineTwoSortedArrayAsSorted(int[] array1, int[] array2)
        {
            var combined = new int[array1.Length + array2.Length];

            var array1Index = 0;
            var array2Index = 0;
            var combinedIndex = 0;

            // Iterate while values exist in both arrays, which allows comparision of unique elements 
            while (array1Index < array1.Length && array2Index < array2.Length)
            {
                if (array1[array1Index] < array2[array2Index])
                {
                    // Add Array1 element value to new array if smaller than Array2 element value
                    combined[combinedIndex] = array1[array1Index];
                    array1Index++;
                }
                else
                {
                    // Add Array2 element value to new array if smaller than Array1 element value
                    combined[combinedIndex] = array2[array2Index];
                    array2Index++;
                }
                combinedIndex++;
            }

            // Add remaining elements if Array1 is larger
            while (array1Index < array1.Length)
            {
                combined[combinedIndex] = array1[array1Index];
                combinedIndex++;
                array1Index++;
            }

            // Add remaining elements if Array2 is larger
            while (array2Index < array2.Length)
            {
                combined[combinedIndex] = array2[array2Index];
                combinedIndex++;
                array2Index++;
            }

            return combined;
        }


        /// <summary>
        /// Given two strings (sub and main), return true if sub is a subsequence of main, or false otherwise. 
        ////    Notes:
        ///         * The letters of sub don't need to be group together or in the same order. 
        ///         * A subsequence of a string is a sequence of characters that can be obtained by deleting some (or none) of the characters from the original string, 
        ///           while maintaining the relative order of the remaining characters. For example, "ace" is a subsequence of "abcde" while "aec" is not.
        ///         * Both sub and main are in sort order
        /// </summary>
        /// <param name="sub">Substring string</param>
        /// <param name="main">Maine string</param>
        /// <returns>True if sub is a subsequence of main, else false</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly 
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// See for more detail:
        /// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4501/
        /// </remarks>
        public static bool IsSubsequence(string sub, string main)
        {
            var subIndex = 0;
            var mainIndex = 0;

            // move one or both indexes while testing, only works if both values are sorted 
            while (subIndex < sub.Length && mainIndex < main.Length)
            {
                if (sub[subIndex] == main[mainIndex])
                {
                    subIndex++;
                }
                mainIndex++;
            }

            // test if all values have been searched by see if subIndex has been incremented more one more so that it matches length
            return subIndex == sub.Length;
        }

        /// <summary>
        /// Given an array of positive integers nums and an integer k, find the length of the longest subarray whose sum is less than or equal to k. 
        /// </summary>
        /// <param name="ints">ints int[]</param>
        /// <param name="max">max int</param>
        /// <returns>The length of longest subarray</returns>
        /// <remarks>
        /// Big O: 
        /// * Time Complexity: O(n) Linear, as number of elements grow, the runtime grows linearly
        /// * Space complexity: O(1) - Constant, memory requirements doesn't signficantly grow based on input
        /// 
        /// See for more detail:
        /// https://leetcode.com/explore/interview/card/leetcodes-interview-crash-course-data-structures-and-algorithms/703/arraystrings/4502/
        /// </remarks>
        public static int LongestSubArray(int[] ints, int max)
        {
            var leftIndex = 0;
            var currentValue = 0;
            var largestSize = 0;

            for (int rightIndex = 0; rightIndex < ints.Length; rightIndex++)
            {
                currentValue += ints[rightIndex];
                while (currentValue > max)
                {
                    currentValue -= ints[leftIndex];
                    leftIndex++;
                }

                largestSize = Math.Max(largestSize, rightIndex - leftIndex + 1);
            }

            return largestSize;
        }

        /// <summary>
        /// You are given an integer array coins representing coins of different denominations and an integer amount representing a total amount of money.
        /// Return the fewest number of coins that you need to make up that amount. If that amount of money cannot be made up by any combination of the coins, return -1.
        /// Notes:
        ///    * Coins Array is provided in ascending sorted order
        ///    * You may assume that you have an infinite number of each kind of coin
        /// </summary>
        /// <param name="coins">coins int[]</param>
        /// <param name="amount">amount int</param>
        /// <returns>Number of coins, or -1 if amount of money cannot be made up by any combination of the coins.</returns>
        /// Big O: 
        /// * Time Complexity: O(amount * coins.length) 
        /// * Space complexity: O(n) - Linear, as the amoutn row, the runtime grows linearly
        /// 
        /// See for more detail:
        /// https://leetcode.com/problems/coin-change/description/
        /// </remarks>
        public static int FewestCoinsForAmount(int[] coins, int amount)
        {
            var dp = new int[amount + 1];
            Array.Fill(dp, amount + 1); // amount + 1 is max value, us that to init each
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                foreach (int coin in coins)
                {
                    if (coin <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                    }
                }
            }
            return dp[amount] > amount ? -1 : dp[amount];
        }

        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. 
        /// Then return the number of elements in nums which are not equal to val.
        /// 
        /// Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
        ///  * Change the array nums such that the first k elements of nums contain the elements which are not equal to val.The remaining elements of nums are not important as well as the size of nums.
        ///  * Return k.
        ///  
        /// Constraints:
        /// * 0 <= nums.length <= 100
        /// * 0 <= nums[i] <= 50
        /// * 0 <= val <= 100
        /// </summary>
        /// <param name="nums">int[]</param>
        /// <param name="val">int to remove from nums</param>
        /// <returns>Nnumber of elements in nums which are not equal to val.</returns>
        /// Big O: 
        /// * Time Complexity: 
        /// * Space complexity: 
        /// 
        /// See for more detail:
        /// https://leetcode.com/problems/remove-element/
        /// </remarks>
        public static int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
}
