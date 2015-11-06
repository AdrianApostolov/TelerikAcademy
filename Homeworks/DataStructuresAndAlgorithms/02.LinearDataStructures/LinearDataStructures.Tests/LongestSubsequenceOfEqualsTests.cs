namespace LinearDataStructures.Tests
{
    using System.Collections.Generic;
    using LongestSubsequenceOfEquals;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LongestSubsequenceOfEqualsTests
    {
        [TestMethod]
        public void ShouldReturnLongestSubsequenceAtTheBeginning()
        {
            var collection = new List<int>() { 1, 1, 1, 1, 2, 2, 3, 3, 3 };
            var longestSubsequence = Startup.FindLongestSubseqience(collection);
            var expectedLongestSubsequence = new List<int>() { 1, 1, 1, 1 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnOnlyOneSubsequenceAtTheEnd()
        {
            var collection = new List<int>() { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4 };
            var longestSubsequence = Startup.FindLongestSubseqience(collection);
            var expectedLongestSubsequence = new List<int>() { 4, 4, 4, 4 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }

        [TestMethod]
        public void ShouldReturnOnlyOneSubsequenceAtTheMiddle()
        {
            var collection = new List<int>() { 1, 2, 2, 3, 3, 3, 3, 4, 4, 4 };
            var longestSubsequence = Startup.FindLongestSubseqience(collection);
            var expectedLongestSubsequence = new List<int>() { 3, 3, 3, 3 };

            CollectionAssert.AreEqual(expectedLongestSubsequence, longestSubsequence);
        }
    }
}