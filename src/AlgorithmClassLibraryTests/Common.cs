using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmClassLibrary.Tests
{
    public class Common
    {
        public static int[] CreateTestDataArray()
        {
            int[] testData = new int[10];

            for (int i = 0; i < testData.Length; i++)
            {
                testData[i] = i;
            }
            return testData;
        }
    }
}
