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
        public void AddTwoNumbers(string inputString, int outputValue)
        {
            Assert.True(Calculator.StringCalculator(inputString) == outputValue);
        }
        
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,4,6", 12)]
        [InlineData("3,3,3", 9)]
        [InlineData("10,20,30", 60)]
        public void AddMultipleNumbers(string inputString, int outputValue)
        {
            Assert.True(Calculator.StringCalculator(inputString) == outputValue);
        }

        [Theory]
        [InlineData("1,2\n3", 6)]
        [InlineData("3\n5\n3,9", 20)]
        [InlineData("1\n3,5\n7", 16)]
        public void UseTwoDelimiters(string inputString, int outputValue)
        {
            Assert.True(Calculator.StringCalculator(inputString) == outputValue);
        }
    }
}
