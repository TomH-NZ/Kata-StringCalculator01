using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            string[] separatedInputValues = inputValueToCalculate.Split(',');

            var returnedValue = 0;
            
            foreach (var word in separatedInputValues)
            {
                Int32.TryParse(word, out var convertedInputValue);

                returnedValue = returnedValue + convertedInputValue;
            }
            
            return returnedValue > 0 ? returnedValue : 0;
        }
    }
}