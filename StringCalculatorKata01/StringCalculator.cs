using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            var separatedInputValues = inputValueToCalculate.Split(',');

            var returnedValue = 0;
            
            foreach (var word in separatedInputValues)
            {
                int.TryParse(word, out var convertedInputValue);

                returnedValue += convertedInputValue;
            }
            
            return returnedValue > 0 ? returnedValue : 0;
        }
    }
}