using System;
using StringCalculatorKata01;
using Xunit;

namespace StringCalculatorKataUnit01Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestShouldReturnZero()
        {
            //Arrange
            var result = Calculator.StringCalculator("2");
            //Act
            //Arrange
            Assert.Equal("1", result);
        }
    }
}