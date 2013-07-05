using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void GetStringFor1()
        {
            Assert.AreEqual("1", FizzBussConsole.FizzBuzz.GetStringFor(1));
        }

        [TestMethod]
        public void GetStringFor2()
        {
            Assert.AreEqual("2", FizzBussConsole.FizzBuzz.GetStringFor(2));
        }

        [TestMethod]
        public void GetStringFor3()
        {
            Assert.AreEqual("Fizz", FizzBussConsole.FizzBuzz.GetStringFor(3));
        }

        [TestMethod]
        public void GetStringFor5()
        {
            Assert.AreEqual("Buzz", FizzBussConsole.FizzBuzz.GetStringFor(5));
        }

        [TestMethod]
        public void GetStringFor15()
        {
            Assert.AreEqual("FizzBuzz", FizzBussConsole.FizzBuzz.GetStringFor(15));
        }

        [TestMethod]
        public void GetStringFor45()
        {
            Assert.AreEqual("FizzBuzz", FizzBussConsole.FizzBuzz.GetStringFor(45));
        }
    }
}
