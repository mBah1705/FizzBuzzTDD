using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzTDD.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void When20_ShouldReturn20_IsInRange()
        {
            FizzBuzz Buzzer = new FizzBuzz();
            Assert.AreEqual(Buzzer.IsInRange(20), true);
        }
    }
}
