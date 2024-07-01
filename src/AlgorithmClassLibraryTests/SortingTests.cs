using Xunit;
using AlgorithmClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary.Tests
{
    public class SortingTests
    {
        [Fact()]
        public void GetLargestIntFromArrayTest()
        {
            int[] intArray = [1, 2, -30, 4, 5];
            int largestInt = Sorting.GetLargestIntFromArray(intArray);

            Assert.Equal(5, largestInt);
        }
    }
}