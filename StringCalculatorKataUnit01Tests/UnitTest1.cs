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
            var result = Calculator.StringCalculator("");
            //Act
            //Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestShouldReturn3()
        {
            //Arrange
            var result = Calculator.StringCalculator("3");
            //Act
            //Assert
            Assert.Equal(3, result);
        }
        
        [Fact]
        public void TestShouldReturn2()
        {
            //Arrange
            var result = Calculator.StringCalculator("2");
            //Act
            //Assert
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void TestShouldReturn4()
        {
            //Arrange
            var result = Calculator.StringCalculator("3, 1");
            //Act
            //Assert
            Assert.Equal(4, result);
        }
        [Fact]
        public void TestShouldReturn10()
        {
            //Arrange
            var result = Calculator.StringCalculator("3, 7");
            //Act
            //Assert
            Assert.Equal(10, result);
        }
    }
}