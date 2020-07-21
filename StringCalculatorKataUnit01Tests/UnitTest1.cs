using System;
using System.Runtime.InteropServices;
using StringCalculatorKata01;
using Xunit;

namespace StringCalculatorKataUnit01Tests
{
    public class KataShould
    {
        [Fact]
        public void ReturnZero()
        {
            //Arrange
            var result = Calculator.StringCalculator("");
            //Act
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Return3()
        {
            //Arrange
            var result = Calculator.StringCalculator("3");
            //Act
            //Assert
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void Return2()
        {
            //Arrange
            var result = Calculator.StringCalculator("2");
            //Act
            //Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("3", 3)]
        [InlineData("", 0)]
        public void ReturnSingleValues(string inputValue, int outputValue)
        {
            var result = Calculator.StringCalculator(inputValue);
            Assert.True(result == outputValue);
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
            var result = Calculator.StringCalculator(inputString);
            Assert.True(result == outputString);
        }
    }
}
// use theory for hte tests