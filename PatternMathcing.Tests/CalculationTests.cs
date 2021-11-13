using NUnit.Framework;
using System;

namespace PatternMathcing.Tests
{
    public class CalculationTests
    {
        [Test]
        [TestCaseSource(typeof(TestCaseSource), nameof(TestCaseSource.TestCaseForCalculationWeekends))]
        public void Calculation_InWeekends(object vehicle, bool inbount, DateTime time, decimal cost)
        {
            var calculator = new TollCallculation.TollCallculation(vehicle, inbount, time);
            Assert.AreEqual(cost, calculator.Calculate());
        }

        [Test] 
        [TestCaseSource(typeof(TestCaseSource), nameof(TestCaseSource.TestCaseForCalculationWordDays))]
        public void Calculation_WordDays(object vehicle, bool inbount, DateTime time, decimal cost)
        {
            var calculator = new TollCallculation.TollCallculation(vehicle, inbount, time);
            Assert.AreEqual(cost, calculator.Calculate());
        }
    }
}