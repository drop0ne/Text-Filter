using System.IO;

namespace TextToWordConverter
{
    public class Config
    {
        public string DefaultSavePath { get; } = @"D:\Users\Main Profile\Documents\Developer Files\My Documents\Converter Output";
        public string StepsLogFile => Path.Combine(DefaultSavePath, "steps_log.txt");
        public string ErrorLogFile => Path.Combine(DefaultSavePath, "error_log.txt");
        public string EnvLogFile => Path.Combine(DefaultSavePath, "env_log.txt");
        public string DiagnosticsLogFile => Path.Combine(DefaultSavePath, "diagnostics_log.txt");
    }
}
