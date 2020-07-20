using System;

namespace StringCalculatorKata01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting Project");
            var result = Calculator.StringCalculator("Orange");
            Console.WriteLine($"Ending Project with result: {result}");
            Console.ReadLine();
        }
    }
}