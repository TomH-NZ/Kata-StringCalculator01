using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            char[] charSeparators = {',', '\n'};
            var separatedInputValues = inputValueToCalculate.Split(charSeparators, StringSplitOptions.None);

            var returnedValue = 0;
            
            foreach (var word in separatedInputValues)
            {
                int.TryParse(word, out var convertedInputValue);

                returnedValue += convertedInputValue;
            }
            
            return returnedValue;
        }

        public static char GetCustomDelimiters(string inputValue)
        {
            if (inputValue.IndexOf('/') != -1)
            {
                
            }
            
            return '0';
        }
    }
}
// ToDo: Split the input string if the first character is "//"
// ToDo: new class to calculate delimiters.  If first char == // then pass back the delimiter.  If first char != // then pass back ',' and '\n' as delimiters.
