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
            Assert.AreEqual(Buzzer.IsFizz(1), false);
        }

        [TestMethod]
        public void When_1_Should_NotReturnFizz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.IsFizz(1), false);
        }

        [TestMethod]
        public void When_6_Should_ReturnFizz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.IsFizz(6), true);
        }

        [TestMethod]
        public void When_10_Should_ReturnBuzz()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.IsBuzz(10), true);
        }
    }
}
