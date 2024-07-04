namespace TextToWordConverter
{
    public class Diagnostics
    {
        private readonly Config config;
        private readonly Logger diagnosticsLogger;

        public Diagnostics(Config config, Logger diagnosticsLogger)
        {
            this.config = config;
            this.diagnosticsLogger = diagnosticsLogger;
        }

        public void RunDiagnostics()
        {
            diagnosticsLogger.Log("Starting diagnostics...");
            diagnosticsLogger.Log($"C# Version: {Environment.Version}");
            diagnosticsLogger.Log($"Default Save Path: {config.DefaultSavePath}");
            diagnosticsLogger.Log($"Default save path exists: {Directory.Exists(config.DefaultSavePath)}");
            diagnosticsLogger.Log("Diagnostics completed.");
        }
    }
}
