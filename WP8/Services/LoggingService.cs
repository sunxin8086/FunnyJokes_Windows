using FunnyJokesPortableClassLibrary.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WP8.Views;
using System.Diagnostics;

namespace WP8.Services
{
    public class LoggingService : ILoggingService
    {
        //private ILogger logger;
        public void Debug(string message) { System.Diagnostics.Debug.WriteLine (message); }
        /*public string Name { get { return logger.Name; } }
        public bool IsTraceEnabled { get { return logger.IsTraceEnabled; } }
        public bool IsDebugEnabled { get { return logger.IsDebugEnabled; } }
        public bool IsInfoEnabled { get { return logger.IsInfoEnabled; } }
        public bool IsWarnEnabled { get { return logger.IsWarnEnabled; } }
        public bool IsErrorEnabled { get { return logger.IsErrorEnabled; } }
        public bool IsFatalEnabled { get { return logger.IsFatalEnabled; } }
        public void Trace(string message, Exception ex = null) { logger.Trace(message, ex); }
        public void Trace(string message, params object[] ps) { logger.Trace(message, ps); }
        public void Debug(string message, Exception ex = null) { logger.Debug(message, ex); }
        public void Debug(string message, params object[] ps) { logger.Debug(message, ps); }
        public void Info(string message, Exception ex = null) { logger.Info(message, ex); }
        public void Info(string message, params object[] ps) { logger.Info(message, ps); }
        public void Warn(string message, Exception ex = null) { logger.Warn(message, ex); }
        public void Warn(string message, params object[] ps) { logger.Warn(message, ps); }
        public void Error(string message, Exception ex = null) { logger.Error(message, ex); }
        public void Error(string message, params object[] ps) { logger.Error(message, ps); }
        public void Fatal(string message, Exception ex = null) { logger.Fatal(message, ex); }
        public void Fatal(string message, params object[] ps) { logger.Fatal(message, ps); }
        public void Log(FunnyJokesPortableClassLibrary.Contracts.Services.LogLevel logLevel, string message, Exception ex) { }
        public void Log(FunnyJokesPortableClassLibrary.Contracts.Services.LogLevel logLevel, string message, params object[] ps) { }
        public bool IsEnabled(FunnyJokesPortableClassLibrary.Contracts.Services.LogLevel level) { return true; }*/
    }
}
