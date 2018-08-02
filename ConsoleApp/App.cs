using SimpleCalculator;
using System;

namespace ConsoleApp
{
    public class App : IApp
    {
        private readonly ICalculator calculator;

        public App(ICalculator calculator)
        {
            this.calculator = calculator;

            // Operations
            try
            {
                DoTestOperations();
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Error: {0}", ex.Message));
            }
            
        }

        public void DoTestOperations()
        {
            calculator.Add(2, 2);
            calculator.Multiply(3, 2);
            calculator.Subtract(1, 1);
            calculator.Divide(1, 0);
        }
    }
}
