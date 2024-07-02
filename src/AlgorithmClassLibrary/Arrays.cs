﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var rightIndex = intArray.Length -1;
            int sum;

            while(leftIndex < rightIndex) 
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
    }
}