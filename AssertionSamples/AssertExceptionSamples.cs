using FluentAssertions;
using FluentAssertions.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AssertionSamples
{
    [TestClass]
    public class AssertExceptionSample
    {
        [TestMethod]
        public void Divide_positive()
        {
            var calculator = new Calculator();
            var actual = calculator.Divide(5, 2);
            Assert.AreEqual(2.5m, actual);
        }

        [TestMethod]
        public void Divide_Zero()
        {
            var calculator = new Calculator();
            var action = new Action(() =>
            {
                calculator.Divide(5, 0);
            });
            //how to assert expected exception?
            action.Should().Throw<YouShallNotPassException>().And.Number.IsSameOrEqualTo(5);
        }
    }

    public class Calculator
    {
        public decimal Divide(decimal first, decimal second)
        {
            if (second == 0)
            {
                throw new YouShallNotPassException();
            }
            return first / second;
        }
    }

    public class YouShallNotPassException : Exception
    {
        public decimal Number { get; set; }
    }
}