using System;

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
            errorLogger.Log($"Unhandled exception: {ex.Message}\n{ex.StackTrace}");
        }
    }
}
