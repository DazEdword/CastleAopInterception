using SimpleLogger;

namespace SimpleCalculator
{
    public class CalculatorFake : Calculator, ICalculator
    {
	    public CalculatorFake(ILogger myLogger) : base(myLogger)
	    {
	    }

	    public override decimal Add(decimal x, decimal y)
        {
            return 1000m;
        }

        public override decimal Divide(decimal x, decimal y)
        {
            return 1000m;
        }

        public override decimal Multiply(decimal x, decimal y)
        {
            return 1000m;
        }

        public override decimal Subtract(decimal x, decimal y)
        {
            return 1000m;
        }
    }
}
