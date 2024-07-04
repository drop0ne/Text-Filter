namespace TextToWordConverter
{
    public class Config
    {
        public string DefaultSavePath { get; set; } = @"D:\Users\Main Profile\Documents\Developer Files\My Documents\Converter Output";
        public string StepsLogFile { get; set; } = "steps.log";
        public string ErrorLogFile { get; set; } = "error.log";
        public string DiagnosticsLogFile { get; set; } = "diagnostics.log";
    }
}
