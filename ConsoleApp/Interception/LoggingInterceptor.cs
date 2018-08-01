using Castle.DynamicProxy;
using SimpleLogger;
using System;

namespace ConsoleApp.Interception
{
    class LoggingInterceptor : IInterceptor
    {
        ILogger Logger;

        public LoggingInterceptor(ILogger logger)
        {
            Logger = logger;
        }

        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("Intercepted!");

            invocation.Proceed();
        }
    }
}
