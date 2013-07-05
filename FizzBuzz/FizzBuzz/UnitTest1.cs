using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetStringFor1()
        {
            Assert.AreEqual("1", FizzBuzz.GetStringFor(1));
        }

        [TestMethod]
        public void GetStringFor2()
        {
            Assert.AreEqual("2", FizzBuzz.GetStringFor(2));
        }

        [TestMethod]
        public void GetStringFor3()
        {
            Assert.AreEqual("Fizz", FizzBuzz.GetStringFor(3));
        }

        [TestMethod]
        public void GetStringFor5()
        {
            Assert.AreEqual("Buzz", FizzBuzz.GetStringFor(5));
        }

        [TestMethod]
        public void GetStringFor15()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz.GetStringFor(15));
        }
    }
}
