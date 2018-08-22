using SimpleCalculator;
using System;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    public class App : IApp
    {
        private readonly ICalculator calculator;

        public App(ICalculator calculator)
        {
            this.calculator = calculator;
            string input = String.Empty;


            Console.WriteLine("Please type your two number operation and press Enter to continue.");
            Console.WriteLine("Quit the app by typing 'exit'");
            while ((input = Console.ReadLine().ToLower()) != "exit")
            {
                // Operations
                try
                {
                    ParseOperation(input);
                } catch (Exception ex)
                {
                    Console.WriteLine(string.Format("Error: {0}", ex.Message));
                }
            }
        }

        public void ParseOperation(string input)
        {
            var operationPattern = @"\s*(\d+)\s*([\+\-\/\*])\s*(\d+)\s*";
            var match = Regex.Match(input, operationPattern);

            var firstOperand = Convert.ToDecimal(match.Groups[1].Value);
            var inputOperator = match.Groups[2].Value;
            var secondOperand = Convert.ToDecimal(match.Groups[3].Value);

            if (!match.Success)
            {
                Console.WriteLine("Couldn't recognise operation. Please try again");
            }

            if (inputOperator == "+")
            {
                calculator.Add(firstOperand, secondOperand);
            }
            else if (inputOperator == "-")
            {
                calculator.Subtract(firstOperand, secondOperand);
            }
            else if (inputOperator == "*")
            {
                calculator.Multiply(firstOperand, secondOperand);
            }
            else {
                calculator.Divide(firstOperand, secondOperand);
            }
        }
    }
}
