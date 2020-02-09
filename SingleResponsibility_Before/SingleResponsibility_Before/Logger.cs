using System;

namespace SingleResponsibility_Before {
    static class Logger { 
        public static void LogLine(string line) {
            Console.WriteLine($"Logger : {line}");
        }
    }
        
}

