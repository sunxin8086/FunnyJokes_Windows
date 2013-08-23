﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunnyJokesPortableClassLibrary.Contracts.Services
{
    public interface ILoggingService
    {
        /*string Name { get; }
        bool IsTraceEnabled { get; }
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }
        void Trace(string message, Exception ex = null);
        void Trace(string message, params object[] ps);
        void Debug(string message, Exception ex = null);
        void Debug(string message, params object[] ps);
        void Info(string message, Exception ex = null);
        void Info(string message, params object[] ps);
        void Warn(string message, Exception ex = null);
        void Warn(string message, params object[] ps);
        void Error(string message, Exception ex = null);
        void Error(string message, params object[] ps);
        void Fatal(string message, Exception ex = null);
        void Fatal(string message, params object[] ps);
        void Log(LogLevel logLevel, string message, Exception ex);
        void Log(LogLevel logLevel, string message, params object[] ps);
        bool IsEnabled(LogLevel level);*/
        void Debug(string message);
    }

    public enum LogLevel
    {
        Trace = 0,
        Debug = 1,
        Info = 2,
        Warn = 3,
        Error = 4,
        Fatal = 5
    }
}
