using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RMSTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[][] searchGrid = new int[10][];
            searchGrid[0] = new int[] { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 };
            searchGrid[1] = new int[] { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 };
            searchGrid[2] = new int[] { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 };
            searchGrid[3] = new int[] { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 };
            searchGrid[4] = new int[] { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 };
            searchGrid[5] = new int[] { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75 };
            searchGrid[6] = new int[] { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38 };
            searchGrid[7] = new int[] { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63 };
            searchGrid[8] = new int[] { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17 };
            searchGrid[9] = new int[] { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45 };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegers(searchGrid, 3);
            Assert.AreEqual(maxProduct, 667755);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[][] searchGrid = new int[10][];
            searchGrid[0] = new int[] { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 };
            searchGrid[1] = new int[] { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 };
            searchGrid[2] = new int[] { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 };
            searchGrid[3] = new int[] { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 };
            searchGrid[4] = new int[] { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 };
            searchGrid[5] = new int[] { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75 };
            searchGrid[6] = new int[] { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38 };
            searchGrid[7] = new int[] { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63 };
            searchGrid[8] = new int[] { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17 };
            searchGrid[9] = new int[] { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45 };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegers(searchGrid, 2);
            Assert.AreEqual(maxProduct, 9603);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int[][] searchGrid = new int[5][];
            searchGrid[0] = new int[] { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 };
            searchGrid[1] = new int[] { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 };
            searchGrid[2] = new int[] { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 };
            searchGrid[3] = new int[] { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 };
            searchGrid[4] = new int[] { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegers(searchGrid, 3);
            Assert.AreEqual(maxProduct, 470547);
        }
        [TestMethod]
        public void TestMethodJW1()
        {
            int[,] searchGrid = new int[10, 10]
            {
                { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 },
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 },
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 },
                { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 },
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 },
                { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75 },
                { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38 },
                { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63 },
                { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17 },
                { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45 }
            };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegersJW(searchGrid, 3);
            Assert.AreEqual(maxProduct, 667755);
        }
        [TestMethod]
        public void TestMethodJW2()
        {
            int[,] searchGrid = new int[10, 10]
            {
                { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 },
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 },
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 },
                { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 },
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 },
                { 24, 47, 32, 60, 99, 3, 45, 2, 44, 75 },
                { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38 },
                { 67, 26, 20, 68, 2, 62, 12, 20, 95, 63 },
                { 24, 55, 58, 5, 66, 73, 99, 26, 97, 17 },
                { 21, 36, 23, 9, 75, 0, 76, 44, 20, 45 }
            };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegersJW(searchGrid, 2);
            Assert.AreEqual(maxProduct, 9603);
        }
        [TestMethod]
        public void TestMethodJW3()
        {
            int[,] searchGrid = new int[5, 10]
            {
                { 8, 2, 22, 97, 38, 15, 0, 40, 0, 75 },
                { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87 },
                { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71 },
                { 52, 70, 95, 23, 4, 60, 11, 42, 69, 24 },
                { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92 }
            };

            var gPC = new GridProductCalculator();
            long maxProduct = gPC.LargestProductOfNAdjacentIntegersJW(searchGrid, 3);
            Assert.AreEqual(maxProduct, 470547);
        }
    }
}
