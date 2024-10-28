using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculationsConstructorTest()
        {
            Calculations calcObject = new Calculations();
        }

        [TestMethod]
        public void AddNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Add(3, 4);
            int expectedValue = 7;
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void MultiplyNumbersTest()
        {
            Calculations calcObject = new Calculations();
            int result = calcObject.Multiply(3, 4);
            int expectedValue = 12;
            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            Calculations calcObject = new Calculations();
            double result = calcObject.Subtract(32, 4);
            Assert.AreEqual(28, result);
        }
    }
}

