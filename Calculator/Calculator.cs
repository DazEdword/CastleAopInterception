using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Calculator : ICalculator
    {
        public virtual decimal Add(decimal x, decimal y) {
            return x + y;
        }

        public virtual decimal Subtract(decimal x, decimal y)
        {
            return x - y;
        }
    }
}
