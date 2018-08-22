using System;

namespace SimpleCalculator
{
    public class InterceptedCalculator : ICalculator
    {
        public decimal Add(decimal x, decimal y) {
            var result = x + y;
            Console.WriteLine(result);
            return result;
        }

        public decimal Subtract(decimal x, decimal y)
        {
            var result = x - y;
            Console.WriteLine(result);
            return result;
        }

        public decimal Multiply(decimal x, decimal y)
        {
            var result = x * y;
            Console.WriteLine(result);
            return result;
        }

        public decimal Divide(decimal x, decimal y)
        {
            try
            {
                var result = x / y;
                Console.WriteLine(result);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
