using System;

namespace solid_proj {
    enum LogLevels {
        Trace,
        Debug,
        Warning,
        Error,
        Fatal
    }

    class ConsoleLogger : ILogger {
        public void WriteLine(string message) {
            Console.WriteLine($"{DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")}: {message}");
        }
    }
}