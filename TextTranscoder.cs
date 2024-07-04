using System.Text;

namespace TextToWordConverter
{
    public class TextTranscoder
    {
        private readonly Encoding defaultEncoding = Encoding.UTF8;

        public string Transcode(byte[] byteData)
        {
            Encoding detectedEncoding = DetectEncoding(byteData);
            string text = detectedEncoding.GetString(byteData);
            return text;
        }

        private Encoding DetectEncoding(byte[] byteData)
        {
            // Simplified for example; in production, use a library for detection
            return Encoding.Default;
        }
    }
}
