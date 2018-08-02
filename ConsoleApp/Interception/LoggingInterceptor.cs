using Castle.DynamicProxy;
using SimpleCalculator.Interception.Attributes;
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
            // Only public methods can be logged
            if (invocation.Method.IsPrivate)
            {
                // Run the intercepted method as normal.
                invocation.Proceed();
            }
            // I'll go through this later, attributes can be used to further augment the
            // flow of intercepted logic.
            else if (AttributeExistsOnMethod<DoNotLog>(invocation))
            {
                // Run the intercepted method as normal.
                Console.WriteLine("(Skipping logging due to attribute)");
                invocation.Proceed();
            }
            else
            {
                // Log and continue
                Logger.LogMessage(invocation.GetType().Name, invocation.Method.Name, "Calculating stuff.", System.Diagnostics.TraceEventType.Information);

                invocation.Proceed();
            }
        }

        private static bool AttributeExistsOnMethod<TAttribute>(IInvocation invocation)
        {
            var attribute = Attribute.GetCustomAttribute(invocation.Method, typeof(TAttribute), true);

            return attribute != null;
        }
    }
}
