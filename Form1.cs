using System;
using System.Text;
using System.Windows.Forms;

namespace TextToWordConverter
{
    public partial class Form1 : Form
    {
        private readonly Config config;
        private readonly Logger stepsLogger;
        private readonly Logger errorLogger;

        public Form1(Config config, Logger diagnosticsLogger, Logger stepsLogger, Logger errorLogger)
        {
            InitializeComponent();

            this.config = config;
            this.stepsLogger = stepsLogger;
            this.errorLogger = errorLogger;

            stepsLogger.Log("Main window initialized.");
        }

        private void RunApplication(object sender, EventArgs e)
        {
            try
            {
                stepsLogger.Log("Application started.");
                string text = textBox.Text;
                UpdateStatus("Checking text encoding...");

                TextTranscoder transcoder = new TextTranscoder();
                byte[] byteData = Encoding.UTF8.GetBytes(text);
                string processedText = transcoder.Transcode(byteData);

                stepsLogger.Log("Text input processed for encoding.");
                UpdateStatus("Text input processed for encoding.");

                UpdateStatus("Processing text...");
                DocumentProcessor processor = new DocumentProcessor(processedText, stepsLogger);
                processor.ProcessDocument();

                string originalOutputPath = Path.Combine(config.DefaultSavePath, "original_output.docx");
                string glitterOutputPath = Path.Combine(config.DefaultSavePath, "glitter_output.docx");

                WordConverter originalConverter = new WordConverter(processor.GetGrid(), stepsLogger);
                originalConverter.ConvertToWord(originalOutputPath);

                stepsLogger.Log("Original text converted to Word.");

                WordConverter glitterConverter = new WordConverter(processor.GetGrid(), stepsLogger);
                glitterConverter.ConvertToWord(glitterOutputPath);

                stepsLogger.Log("Processed text converted to Word.");
                UpdateStatus("Processing completed successfully.");
            }
            catch (Exception ex)
            {
                errorLogger.Log($"Error in RunApplication: {ex.Message}\n{ex.StackTrace}");
                UpdateStatus($"Error: {ex.Message}");
            }
        }

        private void UpdateStatus(string message)
        {
            statusLabel.Text = message;
            progressBar.Value += 10;
        }

        private void Close(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
