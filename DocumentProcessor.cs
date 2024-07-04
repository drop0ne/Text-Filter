using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextToWordConverter
{
    public class DocumentProcessor
    {
        private readonly string text;
        private readonly Logger stepsLogger;
        private readonly string[] grid;

        public DocumentProcessor(string text, Logger stepsLogger)
        {
            this.text = text;
            this.stepsLogger = stepsLogger;
            this.grid = Array.Empty<string>();
        }

        public void ProcessDocument()
        {
            PreprocessText();
            ExtractNumbers();
            ExtractLabels();
            CreateGrid();
        }

        [GeneratedRegex(@"\s+")]
        private static partial Regex WhitespaceRegex();

        [GeneratedRegex(@"\d+")]
        private static partial Regex NumberRegex();

        [GeneratedRegex(@"[A-Za-z]+")]
        private static partial Regex LabelRegex();

        private void PreprocessText()
        {
            stepsLogger.Log("Preprocessing text");
            text = WhitespaceRegex().Replace(text.Trim(), " ");
            stepsLogger.Log("Text preprocessed and grammar checked");
        }

        private void ExtractNumbers()
        {
            stepsLogger.Log("Identifying numbers");
            var numbers = NumberRegex().Matches(text)
                               .Cast<Match>()
                               .Select(m => m.Value)
                               .ToArray();
            stepsLogger.Log("Numbers Identified");
        }

        private void ExtractLabels()
        {
            stepsLogger.Log("Creating labels");
            var labels = LabelRegex().Matches(text)
                              .Cast<Match>()
                              .Select(m => m.Value)
                              .ToArray();
            stepsLogger.Log("Labels created");
        }

        private void CreateGrid()
        {
            stepsLogger.Log("Creating grid");
            grid = text.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            stepsLogger.Log("Grid created");
        }

        public string[] GetGrid()
        {
            return grid;
        }
    }
}
