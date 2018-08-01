using ConsoleApp.DI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start the app");
            Console.ReadKey();

            // DI initialisation
            var container = DependencyInjection.CreateContainer();

            var app = container.Resolve<IApp>();
        }
    }
}
