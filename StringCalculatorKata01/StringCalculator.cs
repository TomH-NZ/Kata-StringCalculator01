using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            char[] charSeparators = new char[] {',', '\n'};
            var separatedInputValues = inputValueToCalculate.Split(charSeparators, StringSplitOptions.None);

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