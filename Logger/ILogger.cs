using System.Diagnostics;

namespace SimpleLogger
{
    public interface ILogger
    {
        void LogMessage(string callingClass, string method, string message, TraceEventType severity);
        void LogMessage(string message, string details, TraceEventType severity);
    }
}