using SimpleLogger;
using System;

namespace SimpleCalculator
{
    public class Calculator : ICalculator
    {
        private readonly ILogger logger;

        public Calculator(ILogger myLogger)
        {
            logger = myLogger;
        }

        public virtual decimal Add(decimal x, decimal y) {
            logger.LogMessage("Calculator", "Add", "Calculating stuff.", System.Diagnostics.TraceEventType.Information);
            var result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public virtual decimal Subtract(decimal x, decimal y)
        {
            logger.LogMessage("Calculator", "Subtract", "Calculating stuff.", System.Diagnostics.TraceEventType.Information);
            var result = x - y;
            Console.WriteLine(result);
            return result;
        }

        public virtual decimal Multiply(decimal x, decimal y)
        {
            logger.LogMessage("Calculator", "Multiply", "Calculating stuff.", System.Diagnostics.TraceEventType.Information);
            var result = x * y;
            Console.WriteLine(result);
            return result;
        }

        public virtual decimal Divide(decimal x, decimal y)
        {
            try
            {
                var result = x / y;
                logger.LogMessage("Calculator", "Divide", "Calculating stuff.", System.Diagnostics.TraceEventType.Information);
                Console.WriteLine(result);
                return result;
            }
            catch (Exception ex)
            {
                logger.LogMessage("Calculator", "Divide", string.Format("Whooops! Error: {0}", ex.Message), System.Diagnostics.TraceEventType.Error);
                throw ex;
            }
        }
    }
}
