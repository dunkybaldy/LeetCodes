using System;

using LeetCodes;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodesTests
{
    [TestClass]
    public class Tests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 1, 2, 3, 5 }, new int[] { 3, 5 })]
        public void SingleNumberThreeTest(int[] input, int[] output)
        {
            var ans = SingleNumberThree.Solve(input);
            CollectionAssert.AreEquivalent(ans, output);
        }

        [DataTestMethod]
        [DataRow(new int[] { 1, 1, 2 }, 2)]
        [DataRow(new int[] { 1, 1, 2, 3, 3, 4, 4, 5, 5}, 2)]
        [DataRow(new int[] { 1, 1, 2, 2, 3, 4, 4 }, 3)]
        [DataRow(new int[] { 3, 3, 7, 7, 10, 11, 11 }, 10)]
        public void SingleElementInASortedArrayTest(int[] integers, int output)
        {
            var ans = SingleElementInASortedArray.Solve(integers);
            Assert.AreEqual(ans, output);
        }
    }
}
