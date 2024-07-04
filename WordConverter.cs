using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace TextToWordConverter
{
    public class WordConverter
    {
        private readonly string[] grid;
        private readonly Logger stepsLogger;

        public WordConverter(string[] grid, Logger stepsLogger)
        {
            this.grid = grid;
            this.stepsLogger = stepsLogger;
        }

        public void ConvertToWord(string outputPath)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(outputPath, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                foreach (var entry in grid)
                {
                    body.AppendChild(new Paragraph(new Run(new Text(entry))));
                }
            }
            stepsLogger.Log($"Word document saved to {outputPath}");
        }
    }
}
