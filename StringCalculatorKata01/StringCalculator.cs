using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            string[] separatedInputValues = inputValueToCalculate.Split(',');

            foreach (var word in separatedInputValues)
            {
                Int32.TryParse(word, out var convertedInputValue);

                if (convertedInputValue > 0)
                {
                    return convertedInputValue;
                }
                return 0; 
            }

            return 0;
        }
    }
}