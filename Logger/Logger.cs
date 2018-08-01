using System;
using System.Diagnostics;

namespace SimpleLogger
{
    public class Logger : ILogger
    {
        public void LogMessage(string callingClass, string method, string message, TraceEventType severity) {
            Console.WriteLine(String.Format("Logging call from {0}, method {1}, severity {3}: \"{2}\"", callingClass, method, message, severity));
        }
        public void LogMessage(string message, string details, TraceEventType severity) {
            Console.WriteLine(String.Format("Logging message severity {2}: {0}. Details: {1}", message, details, severity));
        }
    }
}
