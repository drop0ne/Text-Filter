using System;
using System.IO;

namespace TextToWordConverter
{
    public class Logger
    {
        private readonly string logFile;

        public Logger(string logFile)
        {
            this.logFile = logFile;
            ClearLog();
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
            Console.WriteLine(message);
        }

        public void ClearLog()
        {
            File.WriteAllText(logFile, string.Empty);
        }
    }
}
