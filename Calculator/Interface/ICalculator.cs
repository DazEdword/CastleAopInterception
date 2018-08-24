using System;
using SimpleCalculator.Interception.Attributes;

namespace SimpleCalculator
{
    public interface ICalculator
    {
        decimal Add(decimal x, decimal y);
        decimal Subtract(decimal x, decimal y);

        [DoNotLog]
        decimal Multiply(decimal x, decimal y);

        decimal Divide(decimal x, decimal y);
    }
}