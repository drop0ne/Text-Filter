using System;
using System.Windows.Forms;

namespace TextToWordConverter
{
    public class ExceptionHandler
    {
        private readonly Logger errorLogger;

        public ExceptionHandler(Logger errorLogger)
        {
            this.errorLogger = errorLogger;
        }

        public void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            errorLogger.Log($"Uncaught exception: {ex.Message}\n{ex.StackTrace}");
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(1);
        }
    }
}
