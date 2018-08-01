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
            Logger.LogMessage(invocation.GetType().Name, invocation.Method.Name, "Calculating stuff.", System.Diagnostics.TraceEventType.Information);

            invocation.Proceed();
        }
    }
}
