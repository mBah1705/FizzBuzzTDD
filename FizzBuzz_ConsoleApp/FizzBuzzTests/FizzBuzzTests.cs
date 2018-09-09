using System;
using FizzBuzz_ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void When_20_ShouldReturn20_IsInRange()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.IsInRange(20), true);
        }


        [TestMethod]
        public void When_0_Should_NotReturnFizz_BecauseOutOfRange()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.ReturnValue(0), "0 is out of range!");
        }

        [TestMethod]
        public void When_1_Should_Return_1()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.ReturnValue(1), "1");

        }

        [TestMethod]
        public void When_6_Should_Return_Fizz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.ReturnValue(6), "Fizz");
        }

        [TestMethod]
        public void When_10_Should_Return_Buzz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.ReturnValue(10), "Buzz");
        }

        [TestMethod]
        public void When_15_Should_Only_Return_FizzBuzz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.ReturnValue(15), "FizzBuzz");
        }

        [TestMethod]
        public void When_15_Should_Not_Return_Only_Fizz_Or_Buzz()
        {
            FizzBuzz Buzzer = new FizzBuzz();

            Assert.AreNotEqual(Buzzer.ReturnValue(15), "Fizz");
            Assert.AreNotEqual(Buzzer.ReturnValue(15), "Buzz");
            Assert.AreEqual(Buzzer.ReturnValue(15), "FizzBuzz");
        }
    }
}
