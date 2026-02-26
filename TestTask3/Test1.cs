using task3;

namespace TestTask3
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void RegularInput()
        {
            string answer = Logic.IsCharsInWord("процессор", "информация");
            Assert.AreEqual("нет да да да нет нет", answer);
        }

        [TestMethod]
        public void NoCharsInWord()
        {
            string answer = Logic.IsCharsInWord("hello", "zdravstvuy");
            Assert.AreEqual("нет нет нет нет", answer);
        }

        [TestMethod]
        public void EveryCharInWord()
        {
            string answer = Logic.IsCharsInWord("hello", "olleh");
            Assert.AreEqual("да да да да", answer);
        }

        [TestMethod]
        public void NoCharsInFirstWord()
        {
            string answer = Logic.IsCharsInWord("", "hello");
            Assert.AreEqual("", answer);
        }

        [TestMethod]
        public void NoCharsInSecondWord()
        {
            string answer = Logic.IsCharsInWord("hello", "");
            Assert.AreEqual("нет нет нет нет", answer);
        }
    }
}
