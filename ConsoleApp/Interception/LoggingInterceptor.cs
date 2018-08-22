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
            if (!invocation.Method.IsPublic)
            {
                // Run the intercepted method as normal.
                Console.WriteLine("(Skipping logging due to private method)");
                invocation.Proceed();
            }
            // Attributes
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

                try
                {
                    invocation.Proceed();
                }
                // If exception occurs in intercepted method, log exception as well
                catch (Exception ex)
                {
                    Logger.LogMessage(invocation.GetType().Name, invocation.Method.Name, string.Format("Whooops! Error: {0}", ex.Message), System.Diagnostics.TraceEventType.Error);
                    throw ex;
                }
            }
        }

        private static bool AttributeExistsOnMethod<TAttribute>(IInvocation invocation)
        {
            var attribute = Attribute.GetCustomAttribute(invocation.Method, typeof(TAttribute), true);

            return attribute != null;
        }
    }
}
