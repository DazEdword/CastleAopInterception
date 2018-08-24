namespace SimpleCalculator
{
    public class CalculatorFake : ICalculator
    {
        public decimal Add(decimal x, decimal y)
        {
            return 1000m;
        }

        public decimal Divide(decimal x, decimal y)
        {
            return 1000m;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            return 1000m;
        }

        public decimal Subtract(decimal x, decimal y)
        {
            return 1000m;
        }
    }
}
