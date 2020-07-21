using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string valueToCalculate)
        {
            var convertedString = 0;
            Int32.TryParse(valueToCalculate, out convertedString);

            if (convertedString > 0)
            {
                return convertedString;
            }
            return 0;
        }
    }
}