using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace Alura.Loja.Testes.ConsoleApp.EFCore {

    public class SqlLoggerProvider : ILoggerProvider {

        public static ILoggerProvider Create() {
            return new SqlLoggerProvider();
        }

        public ILogger CreateLogger(string categoryName) {
            if (categoryName == typeof(IRelationalCommandBuilderFactory).FullName) {
                return new SqlLogger();
            }
            return new NullLogger();
        }

        public void Dispose() {

        }
    }

    internal class NullLogger : ILogger {
        public IDisposable BeginScope<TState>(TState state) {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel) {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) {
            //  Nothing
        }
    }

    public class SqlLogger : ILogger {
        public IDisposable BeginScope<TState>(TState state) {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel) {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter) {
            Debug.WriteLine("");
            Debug.WriteLine(formatter(state, exception));
            Debug.WriteLine("");
        }
    }
}

