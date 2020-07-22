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
                var convertedInputValue = 0;
                
                int.TryParse(word, out convertedInputValue);

                returnedValue += convertedInputValue;
            }
            
            return returnedValue;
        }
    }
}
