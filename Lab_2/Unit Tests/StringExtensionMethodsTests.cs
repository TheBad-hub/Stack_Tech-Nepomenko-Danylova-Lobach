using Lib;

namespace Unit_Tests
{
    [TestClass]
    public class StringExtensionMethodsTests
    {
        [TestMethod]
        public void ReverseString_ValidInput_ReturnsReversedString()
        {
            
            string input = "hello";

            string result = input.ReverseString();

            Assert.AreEqual("olleh", result, "The reversed string should match.");
        }

        [TestMethod]
        public void CountChar_ValidInput_ReturnsCorrectCount()
        {
            
            string input = "hello world";
            char charToCount = 'o';

            int result = input.CountChar(charToCount);

            Assert.AreEqual(2, result, "The count of character 'o' should be 2.");
        }

        [TestMethod]
        public void CountChar_NoOccurrences_ReturnsZero()
        {
            
            string input = "hello world";
            char charToCount = 'x';

            int result = input.CountChar(charToCount);

            Assert.AreEqual(0, result, "The count of character 'x' should be 0.");
        }
    }
}
