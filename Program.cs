using System;
using System.Windows.Forms;

namespace TextToWordConverter
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Config config = new Config();
            Logger stepsLogger = new Logger(config.StepsLogFile);
            Logger errorLogger = new Logger(config.ErrorLogFile);
            Logger diagnosticsLogger = new Logger(config.DiagnosticsLogFile);

            Diagnostics diagnostics = new Diagnostics(config, diagnosticsLogger);
            diagnostics.RunDiagnostics();

            ExceptionHandler exceptionHandler = new ExceptionHandler(errorLogger);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(exceptionHandler.HandleException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(config, diagnosticsLogger, stepsLogger, errorLogger));
        }
    }
}
