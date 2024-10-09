using Lib;

namespace Unit_Tests
{
    [TestClass]
    public class ArrayExtensionMethodsTests
    {
        [TestMethod]
        public void CountOccurrences_ValidInput_ReturnsCorrectCount()
        {
            int[] numbers = { 1, 2, 3, 1, 1, 4, 5 };
            int valueToCount = 1;
            int result = numbers.CountOccurrences(valueToCount);
            Assert.AreEqual(3, result, "The count of occurrences should be 3.");
        }

        [TestMethod]
        public void CountOccurrences_EmptyArray_ReturnsZero()
        {
            
            int[] numbers = { };
            int result = numbers.CountOccurrences(1);
            Assert.AreEqual(0, result, "The count of occurrences should be 0 for an empty array.");
        }

        [TestMethod]
        public void GetUniqueElements_ValidInput_ReturnsUniqueElements()
        {
            
            int[] numbers = { 1, 2, 2, 3, 1, 4, 5, 5 };
            int[] result = numbers.GetUniqueElements();
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, result, "The unique elements should match.");
        }

        [TestMethod]
        public void GetUniqueElements_EmptyArray_ReturnsEmptyArray()
        {
            
            int[] numbers = { };
            int[] result = numbers.GetUniqueElements();
            Assert.AreEqual(0, result.Length, "The result should be an empty array for an empty input array.");
        }
    }
}
