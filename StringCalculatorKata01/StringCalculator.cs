using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            var returnedValue = 0;
            
            foreach (char c in inputValueToCalculate)
            {
                int.TryParse(c.ToString(), out var convertedInputValue);

                returnedValue += convertedInputValue;
            }
            
            return returnedValue;
        }

        public static char GetCustomDelimiters(string inputValue) // example string ("//;\n1;2")
        {
            if (inputValue.IndexOf('/') != -1)
            {
                var customDelimiterSubstring = inputValue.Split('\n');
                
            }
            
            return '0';
        }
    }
}

// ToDo: new class to calculate delimiters.  If first char == // then split string and pass back the delimiter.  If first char != // then pass back ',' and '\n' as delimiters.

//feed string into TryParse, the process will remove the non-int and should return the correct values.   Also look at running through the split.string process on the delimiter,
//taking delimiter from 3rd character to \n 

//ToDo: if first char = '/', feed into tryparse
//ToDo: if first char = '-', create function for neg numbers
//ToDo: if first char is not '/' or '-' then create function for int 1000+