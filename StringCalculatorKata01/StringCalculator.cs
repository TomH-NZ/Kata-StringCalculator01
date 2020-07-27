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

            if (inputValueToCalculate.IndexOf("/") != -1 || inputValueToCalculate.IndexOf("\n") != -1)
            {
                foreach (char c in inputValueToCalculate)
                {
                    int.TryParse(c.ToString(), out var convertedInputValue);

                    returnedValue += convertedInputValue;
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
//feed string into TryParse, the process will remove the non-int and should return the correct values.   Also look at running through the split.string process on the delimiter,
//taking delimiter from 3rd character to \n 

//ToDo: if first char = '-', create function for neg numbers
//ToDo: if first char is not '/' or '-' then create function for int 1000+