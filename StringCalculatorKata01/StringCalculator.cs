using System;

namespace StringCalculatorKata01
{
    
    public class Calculator
    {
        public static int StringCalculator(string valueToCalculate)
        {
            string[] separatedValues = valueToCalculate.Split(',');

            foreach (var word in separatedValues)
            {
                var convertedString = 0;
                Int32.TryParse(word, out convertedString);

                if (convertedString > 0)
                {
                    return convertedString;
                }
                return 0; 
            }

            return 0;
        }
    }
}