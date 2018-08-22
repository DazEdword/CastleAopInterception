using ConsoleApp.DI;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the calculator app...");

            // DI initialisation
            var container = DependencyInjection.CreateContainer();

            var app = container.Resolve<IApp>();

            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
