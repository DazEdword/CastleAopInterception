using System;

namespace SimpleCalculator
{
    public class Calculator : ICalculator
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
                return x / y;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
