using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.DI;
using SimpleCalculator;
using SimpleLogger;

namespace ConsoleApp
{
    public class App : IApp
    {
        private readonly ICalculator calculator;

        public App(ICalculator calculator)
        {
            // Operations
            
            this.calculator = calculator;

            DoTestOperations();
        }

        public void DoTestOperations()
        {
            calculator.Add(2, 2);

            calculator.Subtract(1, 1);
        }
    }
}
