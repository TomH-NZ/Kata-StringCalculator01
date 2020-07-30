using System;
using System.Globalization;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            var returnedValue = 0;
            string[] values = inputValueToCalculate.Split(',');

            if (inputValueToCalculate.IndexOf("/") != -1 || inputValueToCalculate.IndexOf("\n") != -1) // use bool?
            {
                string numberPositionInDelimiter = inputValueToCalculate.Substring(4, 1); // change number to be a const at start of program, startingDelimiterIndex 
                int.TryParse(numberPositionInDelimiter, out var delimiterNumber); // return as bool?

                if (delimiterNumber > 0 && inputValueToCalculate.IndexOf("[") != -1) // create function hasSquareBracket and hasNumberInDelimiter, return as bool?
                {
                    /*string numberDelimiterSubstring = inputValueToCalculate.Substring(
                        inputValueToCalculate.IndexOf("\n"),
                        inputValueToCalculate.Length - inputValueToCalculate.IndexOf("\n"));

                    foreach (var c in numberDelimiterSubstring)
                    {
                        int.TryParse(c.ToString(), out var convertedInputValue);

                        returnedValue += convertedInputValue;
                    }*/
                    return 1;
                }
                else
                {
                    foreach (char c in inputValueToCalculate)
                    {
                        int.TryParse(c.ToString(), out var convertedInputValue);

                        returnedValue += convertedInputValue;
                    }
                }
                
            }
            else
            {
                foreach (var value in values)
                {
                    int.TryParse(value, out int convertedValue);

                    if (convertedValue > 999)
                    {
                        returnedValue += 0;
                    }
                    else
                    {
                        foreach (char c in convertedValue.ToString())
                        {
                            int.TryParse(c.ToString(), out var convertedInputValue);

                            returnedValue += convertedInputValue;
                        } 
                    }
                
                }
            }
            
            
            return returnedValue;
        }
    }
}
