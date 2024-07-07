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
    }
}