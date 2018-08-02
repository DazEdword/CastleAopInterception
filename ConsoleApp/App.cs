using SimpleCalculator;
using SimpleCalculator.Interception.Attributes;

namespace ConsoleApp
{
    public class App : IApp
    {
        private readonly ICalculator calculator;

        public App(ICalculator calculator)
        {
            this.calculator = calculator;

            // Operations
            DoTestOperations();
        }

        public void DoTestOperations()
        {
            calculator.Add(2, 2);
            calculator.Multiply(3, 2);
            calculator.Subtract(1, 1);
        }
    }
}
