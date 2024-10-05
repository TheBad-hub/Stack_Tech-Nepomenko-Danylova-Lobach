using Lib;

namespace Unit_Tests
{
    [TestClass]
    public class ExtendedDictionaryTests
    {
        [TestMethod]
        public void Add_ShouldAddElement()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            Assert.AreEqual(1, dictionary.Count);
            Assert.AreEqual(("Apple", 1.5), dictionary[1]);
        }

        [TestMethod]
        public void Remove_ShouldRemoveElement()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            dictionary.Remove(1);
            Assert.AreEqual(0, dictionary.Count);
            Assert.IsFalse(dictionary.ContainsKey(1));
        }

        [TestMethod]
        public void ContainsKey_ShouldReturnTrueIfKeyExists()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            bool contains = dictionary.ContainsKey(1);
            Assert.IsTrue(contains);
        }

        [TestMethod]
        public void ContainsValue_ShouldReturnTrueIfValueExists()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            bool containsValue = dictionary.ContainsValue("Apple", 1.5);
            Assert.IsTrue(containsValue);
        }

        [TestMethod]
        public void Indexer_ShouldReturnCorrectValue()
        {
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            var result = dictionary[1];
            Assert.AreEqual(("Apple", 1.5), result);
        }

        [TestMethod]
        public void Enumerator_ShouldReturnAllElements()
        {
            
            var dictionary = new ExtendedDictionary<int, string, double>();
            dictionary.Add(1, "Apple", 1.5);
            dictionary.Add(2, "Banana", 0.75);

            
            var elements = new List<ExtendedDictionaryElement<int, string, double>>(dictionary);

            
            Assert.AreEqual(2, elements.Count);
            Assert.AreEqual(1, elements[0].Key);
            Assert.AreEqual("Apple", elements[0].Value1);
            Assert.AreEqual(1.5, elements[0].Value2);
            Assert.AreEqual(2, elements[1].Key);
            Assert.AreEqual("Banana", elements[1].Value1);
            Assert.AreEqual(0.75, elements[1].Value2);
        }
    }
}
