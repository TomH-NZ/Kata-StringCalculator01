using System;
using System.Runtime.InteropServices;
using StringCalculatorKata01;
using Xunit;

namespace StringCalculatorKataUnit01Tests
{
    public class KataShould
    {
        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        [InlineData("", 0)]
        public void ReturnSingleValues(string inputValue, int outputValue)
        {
            Assert.True(Calculator.StringCalculator(inputValue) == outputValue);
        }
        
        [Fact]
        public void AddTwoNumbersFact()
        {
            //Arrange
            var result = Calculator.StringCalculator("3, 1");
            //Act
            //Assert
            Assert.Equal(4, result);
        }

        [Theory]
        [InlineData("1,3", 4)]
        [InlineData("7,3", 10)]
        [InlineData("1,1", 2)]
        public void AddTwoNumbers(string inputString, int outputString)
        {
            Assert.True(Calculator.StringCalculator(inputString) == outputString);
        }
    }
}
