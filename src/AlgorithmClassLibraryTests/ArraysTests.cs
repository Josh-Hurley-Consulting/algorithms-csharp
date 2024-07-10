using Xunit;
using AlgorithmClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary.Tests
{
    public class ArraysTests
    {
        [Fact()]
        public void GetLargestIntFromArrayTest_ShouldReturnTrue()
        {
            int[] intArray = [1, 2, -30, 4, 5];
            int largestInt = Arrays.GetLargestIntFromArray(intArray);

            Assert.Equal(5, largestInt);
        }

        [Fact()]
        public void SortedArrayPairsSumTargetTest_ShouldReturnTrue()
        {
            int[] intArray = [1, 2, 4, 6, 8, 9, 14, 15];
            var target = 13;

            Assert.True(Arrays.SortedArrayPairsSumTarget(intArray,target));
        }

        [Fact()]
        public void SortedArrayPairsSumTargetTest_ShouldReturnFalse()
        {
            int[] intArray = [1, 2, 3, 6, 8, 9, 14, 15];
            var target = 13;

            Assert.False(Arrays.SortedArrayPairsSumTarget(intArray, target));
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_SameSize_ShouldReturnEqual()
        {
            int[] intArray1 = [1, 2, 4, 6, 8,  9, 14, 15];
            int[] intArray2 = [2, 3, 5, 8, 9, 10, 11, 13];
            int[] expected = [1, 2, 2, 3, 4, 5, 6, 8, 8, 9, 9, 10, 11, 13, 14, 15];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);
        
            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_DifferentSize_ShouldReturnEqual()
        {
            int[] intArray1 = [1, 2, 4, 6, 8, 9, 14, 15];
            int[] intArray2 = [2, 3, 5, 8, 9, 10];
            int[] expected = [1, 2, 2, 3, 4, 5, 6, 8, 8, 9, 9, 10, 14, 15];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_FirstLargerSetSmallerValues_ShouldReturnEqual()
        {
            int[] intArray1 = [1, 2, 3, 4, 5, 6, 7, 8];
            int[] intArray2 = [2, 3, 5, 8, 9, 10];
            int[] expected = [1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_FirstSmallerSetLagerValues_ShouldReturnEqual()
        {
            int[] intArray1 = [2, 3, 5, 8, 9, 10];
            int[] intArray2 = [1, 2, 3, 4, 5, 6, 7, 8];
            int[] expected = [1, 2, 2, 3, 3, 4, 5, 5, 6, 7, 8, 8, 9, 10];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_FirstSmallerSetSmallerValues_ShouldReturnEqual()
        {
            int[] intArray1 = [1, 2, 3];
            int[] intArray2 = [2, 3, 4, 5];
            int[] expected = [1, 2, 2, 3, 3, 4, 5];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);

            Assert.Equal(expected, actual);
        }

        [Fact()]
        public void CombineTwoSortedArrayAsSortedTest_FirstSmallerSetLargerValues_ShouldReturnEqual()
        {
            int[] intArray1 = [4, 5];
            int[] intArray2 = [1, 2, 3];
            int[] expected = [1, 2, 3, 4, 5];

            var actual = Arrays.CombineTwoSortedArrayAsSorted(intArray1, intArray2);

            Assert.Equal(expected, actual);
        }

        ///         "ace" is a subsequence of "abcde" while "aec" is not.

        [Fact()]
        public void IsSubsequenceTest_CharsTogether_ShouldReturnTrue()
        {
            Assert.True(Arrays.IsSubsequence("ab", "abcde"));
        }

        [Fact()]
        public void IsSubsequenceTest_CharsSeparated_ShouldReturnTrue()
        {
            Assert.True(Arrays.IsSubsequence("ace", "abcde"));
        }

        [Fact()]
        public void IsSubsequenceTest_CharsWrongOrdcer_ShouldReturnFalse()
        {
            Assert.False(Arrays.IsSubsequence("aec", "abcde"));
        }

        [Fact()]
        public void IsSubsequenceTest_NoSharedChars_ShouldReturnFalse()
        {
            Assert.False(Arrays.IsSubsequence("xyz", "abcde"));
        }

        [Fact()]
        public void IsSubsequenceTest_OneSharedChars_ShouldReturnFalse()
        {
            Assert.False(Arrays.IsSubsequence("az", "abcde"));
        }

        [Fact()]
        public void LongestSubArray_ShouldReturn4() 
        {
            Assert.Equal(4, Arrays.LongestSubArray([3, 1, 2, 7, 4, 2, 1, 1, 5], 8));
        }

        [Fact()]
        public void LongestSubArray_ShouldReturn0()
        {
            Assert.Equal(0, Arrays.LongestSubArray([3, 2, 2, 7, 4, 2, 5, 7, 5], 1));
        }

        [Fact()]
        public void FewestCoins_ShouldReturn3()
        {
            Assert.Equal(3, Arrays.FewestCoinsForAmount([1, 2, 5], 11));
        }

        [Fact()]
        public void FewestCoins_ShouldReturn2()
        {
            Assert.Equal(2, Arrays.FewestCoinsForAmount([1, 3, 4, 5], 7));
        }

        [Fact()]
        public void FewestCoins_ShouldReturnNeg1()
        {
            Assert.Equal(-1, Arrays.FewestCoinsForAmount([2], 3));
        }

        [Fact()]
        public void FewestCoins_ShouldReturnZero()
        {
            Assert.Equal(0, Arrays.FewestCoinsForAmount([1], 0));
        }

        [Fact()]
        public void MergeTwoIntArrays_ShouldBeSortedAs122356()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;
            int[] expected = [1, 2, 2, 3, 5, 6];

            Arrays.MergeTwoIntArrays(nums1, nums2, m, n);

            Assert.Equal(expected, nums1);
        }

        [Fact()]
        public void MergeTwoIntArrays_Empty2ndArray_ShouldBeSortedAs1()
        {
            int[] nums1 = [1];
            int m = 1;
            int[] nums2 = [];
            int n = 0;
            int[] expected = [1];

            Arrays.MergeTwoIntArrays(nums1, nums2, m, n);

            Assert.Equal(expected, nums1);
        }

        [Fact()]
        public void RemoveElement_ShouldReturn3()
        {
            int[] nums = [3, 2, 2, 3];
            int val = 3;
            int[] expected = [2, 2, 0, 0];
            int k = Arrays.RemoveElement(nums, val);

            Assert.Equal(2, k);
        }

        [Fact()]
        public void RemoveElement_ShouldReturn5()
        {
            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
            int val = 2;
            int[] expected = [0, 1, 4, 0, 3, 0, 0, 0];
            int k = Arrays.RemoveElement(nums, val);

            Assert.Equal(5, k);
        }
    }
}