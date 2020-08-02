using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string inputValueToCalculate)
        {
            var returnedValue = 0;
            
            string[] values = inputValueToCalculate.Split(',');

            if (HasForwardSlash(inputValueToCalculate) == true || HasSlashN(inputValueToCalculate) == true) 
            {
                if (HasDelimiterNumber(inputValueToCalculate) == true && HasSquareBracket(inputValueToCalculate) == true) 
                {
                    string numberDelimiterSubstring = inputValueToCalculate.Substring(
                        inputValueToCalculate.IndexOf("\n"), inputValueToCalculate.Length - inputValueToCalculate.IndexOf("\n"));

                    var trimmedSubString = numberDelimiterSubstring.Remove(2, 3);
                    
                    foreach (char c in trimmedSubString)
                    {
                        int.TryParse(c.ToString(), out var convertedInputValue);

                        returnedValue += convertedInputValue;
                    }
                    
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
        
        public static bool HasDelimiterNumber(string inputValue)
        {
            var numberDelimiterStartIndex = 4;

            int.TryParse(inputValue.Substring(numberDelimiterStartIndex, 1), out var delimiterNumber);

            if (delimiterNumber > 0)
            {
                return true;
            }

            return false;
        }

        public static bool HasSquareBracket(string inputValue)
        {
            if (inputValue.IndexOf("[") > -1)
            {
                return true;
            }
            return false;
        }

        public static bool HasForwardSlash(string inputValue)
        {
            if (inputValue.IndexOf("/") > -1)
            {
                return true;
            }

            return false;
        }

        public static bool HasSlashN(string inputValue)
        {
            if (inputValue.IndexOf("\n") > -1)
            {
                return true;
            }

            return false;
        }
        
    }
}
